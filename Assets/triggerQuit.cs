using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerQuit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log("trigger");
    }
	void OnTriggerStay(Collider plyr)
    {
		Debug.Log("weszles");
       Application.LoadLevel("Menu");
    }
}
