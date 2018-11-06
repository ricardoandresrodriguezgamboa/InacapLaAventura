using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamera2 : MonoBehaviour {

	public GameObject cameravirtualprincipal;
	public GameObject camera2D;

	void OnTriggerEnter(){

		camera2D.SetActive(false);
		cameravirtualprincipal.SetActive(true);



	}

}
