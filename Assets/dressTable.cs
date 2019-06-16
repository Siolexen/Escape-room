using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dressTable : Gui
{
    public GameObject toAnimate;
    private bool on = false;
    void OnTriggerStay(Collider plyr)
    {
        message = "Wcisnij E";
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (on == true)
                toAnimate.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            else
                toAnimate.transform.localPosition = new Vector3(0.0f, 0.0f, 0.6f);
            on = !on;
        }
    }
}