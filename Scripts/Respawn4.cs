using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn4 : MonoBehaviour {

	public GameObject estadojuegoobject;
	[SerializeField] private Transform Player;
	[SerializeField] private Transform RespawnPoint4;


	void OnTriggerEnter (Collider other){

		if (other.gameObject.CompareTag("Inacapin")) {
			
			Player.transform.position = RespawnPoint4.transform.position;
			estadojuegoobject.GetComponent<EstadojuegoNivelProgra>().restarvidas();


		}
	

	}



}
