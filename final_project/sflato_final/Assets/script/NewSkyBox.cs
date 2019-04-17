using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSkyBox : MonoBehaviour
{
   
    public Material skyTwo;
  


    void OnTriggerEnter(Collider other)
    {
        RenderSettings.skybox = skyTwo;
    }
}
