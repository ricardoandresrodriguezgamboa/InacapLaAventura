using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn5 : MonoBehaviour {

	public GameObject estadojuegoobject;
	[SerializeField] private Transform Player;
	[SerializeField] private Transform RespawnPoint5;


	void OnTriggerEnter (Collider other){

		if (other.gameObject.CompareTag("Inacapin")) {

			Player.transform.position = RespawnPoint5.transform.position;
			estadojuegoobject.GetComponent<EstadojuegoNivelProgra>().restarvidas();

		}


	}



}
