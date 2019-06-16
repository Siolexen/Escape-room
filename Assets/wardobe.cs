using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wardobe : Gui
{
    public GameObject wardrobe_door;
    private double time = 0;
    public GameObject anima;
    int value_key;

    private bool open = false;
    private float z = 0;
    public look status_key_silver;
    // Use this for initialization
    void Start()
    {
        anima = GameObject.Find("Door");
        status_key_silver = GameObject.Find("FirstPersonCharacter").GetComponent<look>();
        //playerScript = thePlayer.GetComponent<look>();
        //gui_scri.open_wardrobe = 0;

    }

    void Update()
    {
        // gui_script = gameObject.GetComponentInParent<Gui>();
        //value = gui_script.wardrobe_key;
        //Debug.Log("gui_script.wardrobe_key yhh " + value);
        //Debug.Log("gui_script.wardrobe_key hh " + gui_scri.open_wardrobe);
        //Debug.Log(string.Join(", ", playerScript));
        Debug.Log("wardrobe hh " + status_key_silver.open_wardrobe);
        //gui_scri.open_wardrobe = 0;
        value_key = status_key_silver.open_wardrobe;
        

        if (open)
        {
            if (z <= 90)
            {
                Debug.Log("z " + z);
                z += 2f;
                anima.transform.localRotation = Quaternion.Euler(0, 0, z);
            }
        }
    }


    void OnTriggerStay(Collider plyr)
    {
        Debug.Log(this.ToString() + " Im the script that is attached to the gameobject.");
        // gui_ward = gui_script.wardrobe_key;

        //playerScript.open_wardrobe -= 10.0f;
        //gui_ward = gameObject.GetComponentInParent<look>().open_wardrobe;


        //Debug.Log("wardrobe hh " + gui_ward);
        //Debug.Log("wardrobe  " + gui_scri.open_wardrobe);
        if (time + 1 < Time.time)
        {
            if(!open)
                message = "Otwórz szafe";
            if (Input.GetKeyDown(KeyCode.E))
            {
                // gui_script.wardrobe_key = 1;
                    if (value_key == 0)
                    {
                        //anima.Play("szafa");
                        message = "Potrzebny klucz";
                    }
                    else
                    {
                        open = true;
                        //message = "Otwarte";
                        
                }
                    time = Time.time;
            }
        }

    }
}