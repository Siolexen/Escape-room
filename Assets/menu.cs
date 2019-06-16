using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
	private Button restart;
	CursorLockMode wantedMode;
    // Start is called before the first frame update
    void Start()
    {
		wantedMode = CursorLockMode.None;
		Cursor.lockState = wantedMode;
		Cursor.visible = true;
        restart = GetComponent<Button>();
        restart.onClick.AddListener(Restart);

    }
	
	void Update(){
		
	}

    // Update is called once per frame
    private void Restart()
    {
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		
       // Application.Quit();
    }
}
