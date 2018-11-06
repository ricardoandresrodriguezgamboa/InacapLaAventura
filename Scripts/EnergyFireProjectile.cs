using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyFireProjectile : MonoBehaviour {

	[SerializeField] private float speed;




	//private GameObject Inacapo;
	//private Vector3 target;


	// Use this for initialization
	void Start () {
		//Inacapo = GameObject.Find("Inacapin");
	
		/*target = new Vector3(Inacapo.transform.position.x,
		transform.position.y,Inacapo.transform.position.z);*/
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = Vector3.MoveTowards(transform.position,target,speed*Time.deltaTime);
		transform.Translate(0,0,speed);

	 
	
 
		
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Inacapin")) {


			FindObjectOfType<USBattack>().collisiondetected = true;



		


		}  


	}




}
