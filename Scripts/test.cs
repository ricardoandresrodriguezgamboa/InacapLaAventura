using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	public GameObject Inacapo;

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Inacapin")) {
			
			Inacapo.GetComponent<Rigidbody>().velocity  =  Vector3.zero;
			Inacapo.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

		
		}



	}
}
