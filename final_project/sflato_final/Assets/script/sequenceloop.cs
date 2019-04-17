using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sequenceloop : MonoBehaviour
{
    public int count = 0;
    public int max;
    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject Obj3;
    public GameObject Obj4;
    public GameObject Obj5;
    public GameObject Obj6;
    public GameObject Obj7;
    public GameObject Obj8;
    public GameObject Obj9;
    public GameObject Obj10;

    // Start is called before the first frame update
    void Start()
    {
        Obj1.SetActive(false);
        Obj2.SetActive(false);
        Obj3.SetActive(false);
        Obj4.SetActive(false);
        Obj5.SetActive(false);
        Obj6.SetActive(false);
        Obj7.SetActive(false);
        Obj8.SetActive(false);
        Obj9.SetActive(false);
        Obj10.SetActive(false);
}

    // Update is called once per frame
    void Update()
    {
        count++;

        if (count == 3)
        {
            Obj1.SetActive(true);
        }

        else if (count == 6)
        {
            Obj2.SetActive(true);
            Obj1.SetActive(false);
        }
        else if (count == 9)
        {
            Obj3.SetActive(true);
            Obj2.SetActive(false);
        }
        else if (count == 12)
        {
            Obj4.SetActive(true);
            Obj3.SetActive(false);
        }
        else if (count == 15)
        {
            Obj5.SetActive(true);
            Obj4.SetActive(false);
        }
        else if (count == 18)
        {
            Obj6.SetActive(true);
            Obj5.SetActive(false);
        }
        else if (count == 21)
        {
            Obj7.SetActive(true);
            Obj6.SetActive(false);
        }
        else if (count == 24)
        {
            Obj8.SetActive(true);
            Obj7.SetActive(false);
        }
        else if (count == 27)
        {
            Obj9.SetActive(true);
            Obj8.SetActive(false);
        }
        else if (count == 30)
        {
            Obj10.SetActive(true);
            Obj9.SetActive(false);
        }
        else if (count == 33)
        {
            Obj10.SetActive(false);
            Restart();
        }

    }

    public void Restart()
    {
        count = 0;
    }
}


