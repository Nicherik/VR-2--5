using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public GameObject boulder, Text, Head_1, Head_2;

    public void Update()
    {
        if(VRTest.active_1 == false || VRTest.active_2 == false)
        {
            TriggerOpenDoor();
        }
    }
    public void TriggerOpenDoor()
    {
        VRTest.col1 = 255;
        VRTest.col2 = 0;
        VRTest.col3 = 0;
        boulder.GetComponent<Renderer>().material.color = new Color32((byte)VRTest.col1, (byte)VRTest.col2, (byte)VRTest.col3, 1);
        Head_1.GetComponent<Renderer>().material.color = new Color32((byte)VRTest.col1, (byte)VRTest.col2, (byte)VRTest.col3, 1);
        Head_2.GetComponent<Renderer>().material.color = new Color32((byte)VRTest.col1, (byte)VRTest.col2, (byte)VRTest.col3, 1);
        Text.SetActive(true);
    }
}
