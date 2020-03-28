using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Aim"))
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }
        
    }
}
