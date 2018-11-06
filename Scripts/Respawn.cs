using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

 
	public GameObject estadojuegoobject;
	[SerializeField] private Transform Player;
	[SerializeField] private Transform RespawnPoint;


	void OnTriggerEnter (Collider other){


		if (other.gameObject.CompareTag ("Inacapin")) {
			
			estadojuegoobject.GetComponent<EstadojuegoNivelProgra> ().restarvidas ();
			Player.transform.position = RespawnPoint.transform.position;
		}


	}


 

 	 
}
