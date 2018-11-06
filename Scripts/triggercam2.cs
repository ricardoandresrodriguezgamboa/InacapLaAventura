using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggercam2 : MonoBehaviour {


	public GameObject camnivelsecreto;
	public GameObject camprincipal;
	public GameObject camnivelsecretoretorno;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter(Collider other){

        if (other.gameObject.CompareTag("Inacapin")) 
        {
            camprincipal.SetActive(true);
            camnivelsecreto.SetActive(false);
            camnivelsecretoretorno.SetActive(false);
        }

	}

}

