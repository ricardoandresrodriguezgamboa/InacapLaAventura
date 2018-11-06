using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOnePoint : MonoBehaviour {


	public static int puntuacion;
	public AudioSource SoundPoint;
	//public Text txtpuntuacion;
	public GameObject ContenedorHUD;


	void OnTriggerEnter (Collider other)
	{	
		if (other.gameObject.CompareTag("Inacapin")) {

			 
			 

			this.gameObject.SetActive(false);

			puntuacion = puntuacion + 1;
			//txtpuntuacion.text = puntuacion.ToString ();
			//PlayerPrefs.SetInt("puntuacion",puntuacion);
			//SoundPoint = GetComponent<AudioSource> ();
			SoundPoint.Play ();

			Animator ContenedorHUDanim = ContenedorHUD.GetComponent<Animator> ();

			ContenedorHUDanim.Play ("HUDanimation");
		
		}
	
	
	}
}
