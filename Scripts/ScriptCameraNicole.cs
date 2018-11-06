using UnityEngine;
using System.Collections;

public class ScriptCameraNicole : MonoBehaviour {


    public Camera cam;
    public Camera cam1;



	// Use this for initialization
	void Start () {
        cam.enabled = true;
        cam1.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1")) 
        {
            cam.enabled = true;
            cam1.enabled = false;

        }

        if (Input.GetKeyDown("2")) 
        {
            cam.enabled = false;
            cam1.enabled = true;
        }
	}
}
