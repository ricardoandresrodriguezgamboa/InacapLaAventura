using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;
using Invector.CharacterController;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

 



public class EstadojuegoNivelProgra : MonoBehaviour{


	//public static EstadojuegoNivelProgra est;

	//public int idpartida=0;
	public  static int score;
	public  static int lives;
	public static int puntuacionPC;
	public bool levelprogrammingcomplete = false;

	public GameObject thirdpersoncontroller;
	public GameObject gameover;
	public GameObject fade;
	public Text txtvidas;
	public Text txtpuntos;
	public AudioSource source;
	public AudioClip audiogameover;
    public AudioClip audioFall;
    public AudioSource audioFallSource;
	public GameObject ContenedorHUD;
 
	public bool lockCursor = true;


 

 

	// Use this for initialization
	void Start () {

		//lives = ThirdPersonCharacter.vidas;

 
   

	}





	// Update is called once per frame
	void Update () {


		//PlayerPrefs.SetInt("lives",lives);
	 
		score = ScoreOnePoint.puntuacion + ScoreTwoPoint.puntuacion + puntuacionPC; 

		txtpuntos.text = score.ToString();
		//vidas = PlayerPrefs.GetInt("vidas",0);
		txtvidas.text = lives.ToString();


		if (Input.GetKeyDown(KeyCode.H) || Input.GetButtonDown("XBOX360_Back")) {
			Animator ContenedorHUDanim = ContenedorHUD.GetComponent<Animator>();

			ContenedorHUDanim.Play("HUDanimation");
 

			//Debug.Log("Mostrar HUD");

		}

 


	}

	public void restarvidas(){

		Animator ContenedorHUDanim = ContenedorHUD.GetComponent<Animator>();

		ContenedorHUDanim.Play("HUDanimation");

		int contadorfade=0;
		lives = lives - 1;
        //public AudioClip audiogameover;

        audioFallSource.clip = audioFall;
        audioFallSource.Play();
	
		fade.SetActive (false);
        //Debug.Log(lives);
        txtvidas.text = lives.ToString();
        Update();
		if (contadorfade==0) {


            /*audioFallSource.clip = audioFall;
            audioFallSource.Play();*/

			fade.SetActive(true);

		}





		//Animator fadeAnim = fade.GetComponent<Animator>();

		//fadeAnim.enabled = true;

		/*if (fadeAnim.GetCurrentAnimatorStateInfo(0).IsName("fade-in")) {
			
			fade.SetActive(false);
		}*/


		//PlayerPrefs.SetInt("vidas",vidas);

		if (lives == 0) {

			lockCursor = !lockCursor;


			Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
			Cursor.visible = !lockCursor;

			source.clip = audiogameover;
			source.Play();
			Time.timeScale = 0.0f;  
			gameover.SetActive(true);


		}

	

	}





	 
 


	public void restartLevel(){

		
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        lives = 5;
		ScoreOnePoint.puntuacion = 0; 
		ScoreTwoPoint.puntuacion = 0;
		puntuacionPC = 0;

	}

	public void volverHall(){

		Time.timeScale = 1;  
		SceneManager.LoadScene("Alpha2018");

	}

	[Serializable]
	public class SaveData{

		public int score;
		public int lives;
		public bool levelprogrammingcomplete = false;
			

	}


	public void Save(){
 
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Open (Application.persistentDataPath + "/savedGames.gd",FileMode.OpenOrCreate);

		SaveData data = new SaveData ();

		data.score = score;
		data.lives = lives;
		data.levelprogrammingcomplete = levelprogrammingcomplete;
 
		bf.Serialize(file, data);
		file.Close();

		Debug.Log("guardando datos...");
	}


	public  void Load(){



			using (FileStream file = File.Open (Application.persistentDataPath + "/savedGames.gd", FileMode.Open)) {

				BinaryFormatter bf = new BinaryFormatter ();
				SaveData data = (SaveData)bf.Deserialize (file);

				score = data.score;
				lives = data.lives;
				levelprogrammingcomplete = data.levelprogrammingcomplete;

			 

//				ThirdPersonCharacter.puntuacion_progra = score;
 
			    
				//txtvidas.text = lives.ToString();
                Debug.Log("cargando datos...");
			}
		 


	}

 
}

 
 



