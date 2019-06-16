using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBook : Gui
{
    public GameObject toAnimate;
    private bool on = false;

    void OnTriggerStay(Collider plyr)
    {
        message = "Wcisnij E";
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (on == true)
                toAnimate.transform.localPosition = new Vector3(0.475f, 0.832f, 0.853f);
            else
                toAnimate.transform.localPosition = new Vector3(0.475f, 0.832f, 0.519f);
            on = !on;
        }
    }
}
