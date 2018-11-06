﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn3 : MonoBehaviour {

	public GameObject estadojuegoobject;
	[SerializeField] private Transform Player;
	[SerializeField] private Transform RespawnPoint3;


	void OnTriggerEnter (Collider other){

		if (other.gameObject.CompareTag("Inacapin")) {
			
			Player.transform.position = RespawnPoint3.transform.position;
			estadojuegoobject.GetComponent<EstadojuegoNivelProgra>().restarvidas();


		}
	

	}



}
