using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn6 : MonoBehaviour {

	public GameObject estadojuegoobject;
	[SerializeField] private Transform Player;
	[SerializeField] private Transform RespawnPoint6;


	void OnTriggerEnter (Collider other){

		if (other.gameObject.CompareTag("Inacapin")) {

			Player.transform.position = RespawnPoint6.transform.position;
			estadojuegoobject.GetComponent<EstadojuegoNivelProgra>().restarvidas();

		}


	}



}

