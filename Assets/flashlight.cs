using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour {
    public Light light;

    void Start () {
        light = GetComponent<Light>();
        light.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            light.enabled = !light.enabled;
        }
    }
}
