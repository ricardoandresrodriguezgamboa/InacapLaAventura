using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggercam : MonoBehaviour {


	public GameObject camnivelsecreto;
	public GameObject camprincipal;

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inacapin"))
        {
            camprincipal.SetActive(false);
            camnivelsecreto.SetActive(true);
        }

		
 



	}



	void OnTriggerExit(){
	
		//camprincipal.SetActive(true);
		//camnivelsecreto.SetActive(false);
	 


	
	
	}











}
