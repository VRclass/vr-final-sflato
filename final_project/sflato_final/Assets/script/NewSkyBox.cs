using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSkyBox : MonoBehaviour
{
    public bool NextSkyBox = false;
    //public Material One;
    //public Material Two;
    //public Material Three;
    public Material[] MyMaterials;
    public int arrayPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RightHand")
        {
            if (arrayPos < MyMaterials.Length)
            {
                arrayPos++;
            }
            else { arrayPos = 0; }

            RenderSettings.skybox = MyMaterials[arrayPos];
            Debug.Log("enter" + other.gameObject.name);
        }
    }
    //void OnTriggerExit(Collider other)
    //{
    //    NextSkyBox = false;
    //    //RenderSettings.skybox = One;
    //    Debug.Log("exit");
    //}



   


}
