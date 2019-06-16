using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class look : MonoBehaviour
{

    int[] code = new int[6];
    protected double time = 0;
    public GameObject button;
    public int pivot = 0;
    public TextMesh t;
    public Animator anim;
    public GameObject rurka;

    public int open_wardrobe = 0;
    public int open_doors = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.ToString() + " Im the script that is attached to the gameobject.");
        // gui_script.wardrobe_key = 22;
        // open_wardrobe = 5;
        anim = GameObject.Find("drzwiczki").GetComponent<Animator>();
        Debug.Log("Start");
        for (int i = 0; i < 6 ; i++)
        {
            code[i] = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
         
            Application.LoadLevel("Menu");

        }
        //Debug.Log(Time.time + " ww");
        for (int i = 0; i < 10; i++)
        {

            if (time+0.3 < Time.time)
            {
                button = GameObject.Find("Cube." + i);
                button.GetComponent<Renderer>().material.color = new Color(152, 152, 152);
            }
            Debug.Log("lol22 4 " + this.open_wardrobe);
        }
        InteractRaycastAlternative();
    }

    void InteractRaycastAlternative()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        

        if (Input.GetKeyDown(KeyCode.E))
        {
           
           // Debug.Log(gui_script);
            if (Physics.Raycast(ray, out hit, 45.0f))
            {
               // Debug.Log(hit.transform.gameObject.name);
              //  Debug.Log("lol " + gui_script.wardrobe_key);
                if(hit.transform.gameObject.name == "key_silver")
                {

                    Destroy(hit.transform.gameObject);
                    //  gui_script.wardrobe_key = 1;
                    this.open_wardrobe = 1;
                    Debug.Log("lol22 " + this.open_wardrobe);
                }

                if (hit.transform.gameObject.name == "key_gold")
                {
                    hit.transform.localPosition = new Vector3(28.98f, 21.3f, 22.95f);
                   
                    this.open_doors = 1;
                    Debug.Log("lol22 " + this.open_wardrobe);
                }

                if (hit.transform.gameObject.name == "Rurka")
                {
                    rurka = GameObject.Find("Rurka");
                    rurka.transform.localPosition = new Vector3(1f, 1f, 20f);
                    rurka.transform.localRotation = Quaternion.Euler(0, 0, 0);
                }
                    

                t = GameObject.Find("textCode").GetComponent<TextMesh>();
                time = Time.time;
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log(Time.time + " ss");
                switch (hit.transform.gameObject.name)
                {
                    case "Cube.0":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 0;
                        t.text += "0";
                        pivot++;
                        break;

                    case "Cube.1":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 1;
                        t.text += "1";
                        pivot++;
                        break;

                    case "Cube.2":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 2;
                        t.text += "2";
                        pivot++;
                        break;

                    case "Cube.3":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 3;
                        t.text += "3";
                        pivot++;
                        break;

                    case "Cube.4":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 4;
                        t.text += "4";
                        pivot++;
                        break;

                    case "Cube.5":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 5;
                        t.text += "5";
                        pivot++;
                        break;

                    case "Cube.6":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 6;
                        t.text += "6";
                        pivot++;
                        break;

                    case "Cube.7":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 7;
                        t.text += "7";
                        pivot++;
                        break;

                    case "Cube.8":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 8;
                        t.text += "8";
                        pivot++;
                        break;

                    case "Cube.9":
                        hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                        code[pivot] = 9;
                        t.text += "9";
                        pivot++;
                        break;
                }

                //kod dostepu 
                if (code[0] == 3 && code[1] == 2 && code[2] == 3 && code[3] == 9 && code[4] == 6 && code[5] == 7)
                {
                    t.text = "OK";
                   
                    anim.Play("open");
                    Debug.Log("kod OK");
                }

                if (pivot == 6)
                {
                    pivot = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        code[i] = -1;
                        t.text = "";
                    }
                }
       
               // Debug.Log(hit.transform.gameObject.name);
            }
            else
            {
                //Debug.Log("-");
            }
        }
    }

    void InteractRaycast()
    {
        /*
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit" + hit.distance);
            GameObject hitGameobject = hit.transform.gameObject;
            string hitFeedback = hitGameobject.name;
            Debug.Log(hitFeedback);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
        */
        Vector3 playerPosition = transform.position;
        Vector3 forwardDirection = transform.forward;
        Ray interactionRay = new Ray(playerPosition, forwardDirection);
        RaycastHit interactionRayHit;
        float interactionRayLength = 5.0f;

        Vector3 interactionRayEndpoint = forwardDirection * interactionRayLength;
        Debug.DrawLine(playerPosition, interactionRayEndpoint);

        bool hitFound = Physics.Raycast(interactionRay, out interactionRayHit, interactionRayLength);
        Debug.Log(hitFound);
        if (hitFound)
        {
            GameObject hitGameobject = interactionRayHit.transform.gameObject;
            string hitFeedback = hitGameobject.name;
            Debug.Log(hitFeedback);
        }
        else
        {
            string nothingHitFeedback = "-";
            Debug.Log(nothingHitFeedback);
        }

        /*
        Vector3 playerPosition = transform.position;
        Vector3 forwardDirection = transform.forward;
        Debug.Log("dsafds");
        
        InteractRaycast interactionRay = new InteractRaycast(playerPosition, forwardDirection);
        RaycasHit interactionRayHit;
        float interactionRayLength = 5.0f;

        Vector3 interactionRayEndpoint = forwardDirection * interactionRayLength;
        Debug.DrawLine(playerPosition, interactionRayEndpoint);

        bool hitFound = Physics.Raycast(interactionRay, out interactionRayHit, interactionRayLength);
        if (hitFound)
        {
            GameObject hitGameobject = interactionRayHit.transform.gameObject;
            string hitFeedback = hitGameobject.name;
            Debug.Log(hitFeedback);
        }
        else
        {
            string nothingHitFeedback = "-";
            Debug.Log(nothingHitFeedback);
        }
        */
    }

}
