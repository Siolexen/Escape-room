using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic : MonoBehaviour
{
    int a, b, c = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) || a == 1)
        {
            a = 1;
            if (Input.GetKeyDown(KeyCode.H) || b == 1)
            {
                b = 1;
                if (Input.GetKeyDown(KeyCode.U) || c == 1)
                {
                    c = 1;
                    if (Input.GetKeyDown(KeyCode.J))
                    {
                        Destroy(GameObject.Find("RFAIPP_Fridge"));
                    }
                }
            }
        }
    }
}
