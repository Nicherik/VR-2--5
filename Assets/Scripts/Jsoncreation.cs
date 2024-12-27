using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.EventSystems;
public class Jsoncreation : MonoBehaviour
{
    public Text msg;
    public Text lvl;
    public Slider sensor1;
    public Text sensor2;
    public string jsonURL;
    public jsonClass jsnData;
    void Start()
    {
        sensor1.interactable = false;
        StartCoroutine(getData());
    }
    IEnumerator getData()
    {
        Debug.Log("Loading data...");
        var uwr = new UnityWebRequest(jsonURL);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var dataFile = Path.Combine(Application.persistentDataPath, "data.json");
        var dh = new DownloadHandlerFile(dataFile);
        dh.removeFileOnAbort = true;
        uwr.downloadHandler = dh;
        yield return uwr.SendWebRequest();
        if(uwr.result != UnityWebRequest.Result.Success)
        {
            msg.text = "Error!";
        }
        else
        {
            Debug.Log("The file is saved at the path: " + dataFile);
            jsnData = JsonUtility.FromJson<jsonClass>(File.ReadAllText(Application.persistentDataPath + "/data.json"));
            msg.text = jsnData.Message.ToString();
            lvl.text = jsnData.Level.ToString();
            sensor1.value = jsnData.testParam;
            sensor2.text = jsnData.testParam.ToString();
            yield return StartCoroutine(getData());
        }
    }
    [System.Serializable]
    public class jsonClass
    {
        public string Message;
        public int Level;
        public int testParam;
    }
}
