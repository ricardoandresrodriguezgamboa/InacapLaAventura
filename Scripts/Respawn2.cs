using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn2 : MonoBehaviour {

	public GameObject estadojuegoobject;
	[SerializeField] private Transform Player;
	[SerializeField] private Transform RespawnPoint2;


	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag("Inacapin")) {

			Player.transform.position = RespawnPoint2.transform.position;
			estadojuegoobject.GetComponent<EstadojuegoNivelProgra>().restarvidas();

		}


	}



}
