using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class menu : MonoBehaviour {


 
	public void inciarjuego(){

		SceneManager.LoadScene("home");
	
	}

	public void cargarpartida(){

	

		if (File.Exists (Application.persistentDataPath + "/savedGames.gd")) {
			EstadojuegoNivelProgra est = new EstadojuegoNivelProgra ();
			 SceneManager.LoadScene("home");
		     est.Load ();
		
		} else {
		
			Debug.Log("el archivo no existe");
		
		}

	
	

	}


}
