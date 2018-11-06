using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTwoPoint : MonoBehaviour {

	public static int puntuacion;
	public AudioSource SoundPoint;
	//public Text txtpuntuacion;
	public GameObject ContenedorHUD;


	void OnTriggerEnter (Collider other)
	{	
	 
	 
		if (other.gameObject.CompareTag("Inacapin")) {

			this.gameObject.SetActive(false);
			SoundPoint.Play ();
			//StartCoroutine (PointsNumerator());

	  

			puntuacion = puntuacion + 2;
 
 
			Animator ContenedorHUDanim = ContenedorHUD.GetComponent<Animator> ();

			ContenedorHUDanim.Play ("HUDanimation"); 


	


	}


	}

	/*IEnumerator PointsNumerator(){

		puntuacion = puntuacion + 1;

		yield return new WaitForSeconds(0.30f);

		puntuacion = puntuacion + 1;

		//yield return new WaitForSeconds(0.5f);




	}*/




}
