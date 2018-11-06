using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiocamarasecretoretorno : MonoBehaviour {

	public GameObject camsecretoretorno;
	public GameObject camsecreto;
	private Animator platformAnim;

	// Use this for initialization
	void Start () {
		platformAnim =  this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerStay(){

		camsecreto.SetActive(false);
		camsecretoretorno.SetActive(true);
		platformAnim.SetBool("ActivatePlatform",true);


	}
}
