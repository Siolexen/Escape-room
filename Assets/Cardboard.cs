using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardboard : Gui
{
    public GameObject anima;
    public GameObject cardboards;
    public GameObject key_gold;
    private int drop = 1;
    private int one = 1;
    private float x = 0;
    private float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        anima = GameObject.Find("Rurka");
        key_gold = GameObject.Find("key_gold");
        cardboards = GameObject.Find("CarboardBox_1p");
    }

    // Update is called once per frame
    void Update()
    {
      if(drop == 2)
        {
            if (x >= -20)
            {
                Debug.Log("z " + x);
                x -= 2f;
                z -= 0.2f;
                anima.transform.localRotation = Quaternion.Euler(x, 0, 0);
                cardboards.transform.localPosition = new Vector3(8.985079f, 4.49f, z);
            }
            else
            {
                if(one == 1)
                {
                    anima.transform.localPosition = new Vector3(20, 20, 20);
                    key_gold.transform.localPosition = new Vector3(8.98f, 1.3f, -2.95f);
                    one = 0;
                }
                
               // Debug.Log(this.ToString(key_gold) + "meobject.");
            }
        }
    }

    void OnTriggerStay(Collider plyr)
    {
        Debug.Log(this.ToString() + " Im the script that is attached to the gameobject.");
        
        Vector3 localPos = anima.transform.localPosition;

        if (localPos.z > 15)
        {
            if(drop == 1)
                message = "Zrzuc pudelko";
            if (Input.GetKeyDown(KeyCode.E))
            {
                // gui_script.wardrobe_key = 1;
                if (drop == 1)
                {
                    anima.transform.localPosition = new Vector3(8.93f, 3.49f,0.351f);
                    drop = 2;
                }
            }
        }
    }
}
