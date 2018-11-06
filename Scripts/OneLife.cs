using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneLife : MonoBehaviour {

	public AudioSource OnelifeClip;
	public GameObject ContenedorHUD;
	 
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Inacapin")) {


			OnelifeClip.Play();
			this.gameObject.SetActive(false);
			EstadojuegoNivelProgra.lives = EstadojuegoNivelProgra.lives + 1;

			Animator ContenedorHUDanim = ContenedorHUD.GetComponent<Animator>();

			ContenedorHUDanim.Play("HUDanimation");

		}


	}

}
