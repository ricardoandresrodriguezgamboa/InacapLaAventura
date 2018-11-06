using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Estadojuegohall : MonoBehaviour {

	//public Text txtscore;
	public Text txtlives;

 
	 // Update is called once per frame
	void Start () {


			
		if (EstadojuegoNivelProgra.lives == 0) {

			EstadojuegoNivelProgra.lives = 5;
			 
			txtlives.text = EstadojuegoNivelProgra.lives.ToString();

			
		} else {

			txtlives.text = EstadojuegoNivelProgra.lives.ToString();

		}
		 
	

	}
}
