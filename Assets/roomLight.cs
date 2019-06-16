using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomLight  : Gui
{
    public GameObject light;
    public GameObject s;
    private bool on = false;

    void Start()
    {
       // light.SetActive(!on);
    }

    // Use this for initialization
    void OnTriggerStay(Collider plyr)
    {
        message = "Wcisnij E";
        if (Input.GetKeyDown(KeyCode.E))
        {
            light.SetActive(!on);
            if (on == true)
                s.transform.rotation = Quaternion.Euler(new Vector3(-60, 0, 0));
            else
                s.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            on = !on;
        }
    }
}
