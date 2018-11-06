using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeGastronomia : MonoBehaviour {

	public Transform Head;
	public Transform Body;
	private GameObject Inacapin;


	// Use this for initialization
	void Start () {

		Inacapin = GameObject.Find ("Inacapin");

	}

	// Update is called once per frame
	void Update () {



	}

	void OnTriggerStay(Collider other){

		if (other.gameObject.CompareTag("Inacapin")) {
			
			Vector3 target = new Vector3 (Inacapin.transform.position.x, 2, Inacapin.transform.position.z);


			Head.LookAt(target);


		}


	}
}
