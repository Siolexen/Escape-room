using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public float timeStart = 600;
    public Text textBox;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = (true);
        Debug.Log(this.ToString() + " TIME.");
        textBox.text = timeStart.ToString();
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if (timeStart < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
