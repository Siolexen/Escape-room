using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : Gui
{
    public look gold_key;
    public GameObject toAnimate;
    private bool on = false;
    int value_gold_key;
    int open_door = 0;
    private float y = 180f;
    public GameObject doors;

    void Start()
    {
        doors = GameObject.Find("pivot_door");
        gold_key = GameObject.Find("FirstPersonCharacter").GetComponent<look>();
    }

    void Update()
    {
        value_gold_key = gold_key.open_doors;
        Debug.Log("gold key " + value_gold_key);

        if (open_door == 1)
        {
            Debug.Log("yyxxxyy " + y);
            if (y >= 90)
            {
                Debug.Log("yyyyyy " + y);
                y -= 2f;
                doors.transform.localRotation = Quaternion.Euler(0, y, 90);
            }
        }

    }

    void OnTriggerStay(Collider plyr)
    {
        if(value_gold_key == 0)
        {
            message = "Znajdz klucz!";
        }
        else
        {
            message = "Znalazłeś klucz! Gratulacje";
            open_door = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
           // Debug.Log("open_door hh " + open_door);
          //  open_door = 1;
        }
    }
}
