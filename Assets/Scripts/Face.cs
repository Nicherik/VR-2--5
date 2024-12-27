using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public GameObject MC;
    public void Update()
    {
        if (VRTest.active_1 == false || VRTest.active_2 == false)
        {
            MoveMC();
        }
    }

    public void MoveMC()
    {
        MC.transform.position = new Vector3((float)-1.5, 1, (float)-11.04);
    }
}
