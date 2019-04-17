using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour {

    public UnityEvent triggerEvent;

    void OnTriggerEnter(Collider other) 
    {
        triggerEvent.Invoke();
    }
        
}
