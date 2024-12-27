using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class VRTest : MonoBehaviour
{
    public GameObject Quad_1, Quad_2, Beam_1, Beam_2;
    static public int col1, col2, col3;
    public double x_Quad_1 = -0.55;
    static public bool active_1 = true, active_2 = true;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if(active_1 == false || active_2 == false)
        {
            Beam_1.SetActive(false);
            Beam_2.SetActive(false);
        }
    }
    public void ClickButton_1()
    {
        /* col1 = Random.Range(0, 255);
        col2 = Random.Range(0, 255);
        col3 = Random.Range(0, 255); 
        Quad_1.GetComponent<Renderer>().material.color = new Color32((byte)col1, (byte)col2 , (byte)col3, 1);*/
        if (active_1)
        {
            Quad_1.SetActive(false);
            active_1 = false;
        }
        else
        {
            Quad_1.SetActive(true);
            active_1 = true;
        }
    }
    public void ClickButton_2()
    {
        /* col1 = Random.Range(0, 255);
        col2 = Random.Range(0, 255);
        col3 = Random.Range(0, 255); 
        Quad_2.GetComponent<Renderer>().material.color = new Color32((byte)col1, (byte)col2, (byte)col3, 1);*/
        if (active_2)
        {
            Quad_2.SetActive(false);
            active_2 = false;
        }
        else
        {
            Quad_2.SetActive(true);
            active_2 = true;
        }
    }
}
