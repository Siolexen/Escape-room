﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
	private Button quitButton;
    // Start is called before the first frame update
    void Start()
    {

        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(Quit);

    }
	
	void Update(){
		
	}

    // Update is called once per frame
    private void Quit()
    {
		 Application.Quit();
    }
}
