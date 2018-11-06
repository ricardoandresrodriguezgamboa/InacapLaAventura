using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamera1 : MonoBehaviour {

	public GameObject cameravirtualprincipal;
	public GameObject camera2D;

	void OnTriggerEnter(){
	
		cameravirtualprincipal.SetActive(false);
		camera2D.SetActive(true);
	
	
	}



}
