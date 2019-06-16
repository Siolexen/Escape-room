using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamplight : Gui
{
    public GameObject light;
    private bool on = false;

    // Use this for initialization
    void OnTriggerStay(Collider plyr)
    {
        message = "Wcisnij E";
        if (Input.GetKeyDown(KeyCode.E))
        {
            light.SetActive(!on);
            on = !on;
        }
    }
}
