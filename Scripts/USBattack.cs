using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class USBattack : MonoBehaviour {


	[SerializeField] private GameObject FireEnergy;
	private  float timeBtwShots;
	public float startTimeBtwShots;
	public Transform respawnPosition;
	private enemy eInstance;
	public bool collisiondetected=false;

	// Use this for initialization
	void Start () {


		eInstance = FindObjectOfType<enemy> ();

	 
		
	}
	
	// Update is called once per frame
	void  Update () {

		if (collisiondetected) {
			
			StartCoroutine(eInstance.DeathScene4());
			collisiondetected=false;
			
		}

 

		if (timeBtwShots <= 0) {

			FireEnergy = Instantiate(FireEnergy, respawnPosition.position,  respawnPosition.rotation);

 			Destroy (FireEnergy, 4);

			//Debug.Log(startTimeBtwShots);
		 
	 
			//Instantiate (FireEnergy);
			//Instantiate (FireEnergy,transform.position,  transform.rotation);
			timeBtwShots = startTimeBtwShots;
		
		}else{

			timeBtwShots -= Time.deltaTime;
		}
	


		
	}





	 

}
