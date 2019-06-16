using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gui : MonoBehaviour
{
    //static public int wardrobe_key = 0;
    public string message = "";

    void Start()
    {
       // wardrobe_key = 10;
    }

    void OnGUI()
    {
       
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), message);
        //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 100, 50), "O");
    }

    void OnTriggerExit(Collider other)
    {
        message = "";
    }
}
