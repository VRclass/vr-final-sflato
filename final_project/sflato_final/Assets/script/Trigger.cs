using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        obj.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        obj.SetActive(false);
    }
    // void OnTriggerStay(Collider other)
    //{
        
    //} 

}
