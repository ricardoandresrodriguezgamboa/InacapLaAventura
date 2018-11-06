using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class FinalPlatforms : MonoBehaviour {


	public GameObject interactButtonA;
	public GameObject interactButtonB;
	public GameObject interactButtonC;
	public GameObject interactButtonD;
	public GameObject interactButtonE;
	public GameObject interactButtonF;

	public GameObject camyes;
	public GameObject camfail;
	public GameObject camfinal;
	public GameObject campantalla;


	public bool desactivado = false;

	private GameObject platform;

	public GameObject portalfail;
	public AudioSource audiofail;

	public GameObject portalyes;
	public AudioSource audioyes;

    public AudioSource audioSpin;
    public AudioSource audioJump;

    public AudioSource rightStep;
    public AudioSource leftStep;
	//public GameObject ContenedorHUD;


//	public VideoPlayer deathclip;

	public GameObject CanvasReprob;
	public static float notaFinal;
	public static float puntos;
	public Text TextReprob;
	public GameObject CanvasAprob;
	public Text TextAprob;

	//public GameObject estadojuegoobject;
	//[SerializeField] private Transform Player;
	//[SerializeField] private Transform RespawnPoint;



	void OnTriggerStay(Collider other){


		if (other.gameObject.CompareTag ("answerA")){

			Debug.Log("answerA");
			platform = GameObject.Find("C_Platform026");

			if (desactivado)
			{
				interactButtonA.SetActive(false);
			}
			else
			{

				interactButtonA.SetActive(true);
			}


		} else if (other.gameObject.CompareTag ("answerB")){

			platform = GameObject.Find("C_Platform027");

			if (desactivado)
			{
				interactButtonB.SetActive(false);
			}
			else
			{

				interactButtonB.SetActive(true);
			}

			//Debug.Log("answerB");

		} else if (other.gameObject.CompareTag ("answerC")){

			platform = GameObject.Find("C_Platform028");

			if (desactivado)
			{
				interactButtonC.SetActive(false);
			}
			else
			{

				interactButtonC.SetActive(true);
			}
			//Debug.Log("answerC");


		} else if (other.gameObject.CompareTag ("answerD")){

			platform = GameObject.Find("C_Platform029");

			if (desactivado)
			{
				interactButtonD.SetActive(false);
			}
			else
			{

				interactButtonD.SetActive(true);
			}
			//Debug.Log("answerD");


		} else if (other.gameObject.CompareTag ("answerE")){

			platform = GameObject.Find("C_Platform030");

			if (desactivado)
			{
				interactButtonE.SetActive(false);
			}
			else
			{

				interactButtonE.SetActive(true);
			}
			//Debug.Log("answerE");


		} else if (other.gameObject.CompareTag ("answerF")){

			platform = GameObject.Find("C_Platform031");

			if (desactivado)
			{
				interactButtonF.SetActive(false);
			}
			else
			{

				interactButtonF.SetActive(true);
			}

			//Debug.Log("answerF");

		} 

	}


	void OnTriggerExit(Collider other)
	{

		if (interactButtonA && interactButtonB && interactButtonC && interactButtonD && interactButtonE  && interactButtonF != null) {

			interactButtonA.SetActive(false);
			interactButtonB.SetActive(false);
			interactButtonC.SetActive(false);
			interactButtonD.SetActive(false);
			interactButtonE.SetActive(false);
			interactButtonF.SetActive(false);
		}




	}

	public void incorrect()
	{

		//m_Animator.SetBool("IsInteract",true);



		Renderer ColorPlatform = platform.GetComponent<Renderer>();

		ColorPlatform.material.shader = Shader.Find("Standard");
		ColorPlatform.material.SetColor("_Color", Color.red);
		ColorPlatform.material.SetColor("_EmissionColor", Color.red);


		audiofail.Play();
		desactivado = true;

		StartCoroutine(AnswerInCorrectTime ());



	}

	public void correct() {

		//Dejar quieto a inacapo

		//m_Animator.SetBool("IsInteract",true);

		Renderer ColorPlatform = platform.GetComponent<Renderer>();

		ColorPlatform.material.shader = Shader.Find("Standard");
		ColorPlatform.material.SetColor("_Color", Color.green);
		ColorPlatform.material.SetColor("_EmissionColor", Color.green);
		audioyes.Play();
		desactivado = true;

		StartCoroutine(AnswerCorrectTime ());

	}

    public void spinSound()
    {
        audioSpin.Play();
    }

    public void jumpSound()
    {
        audioJump.Play();
        Debug.Log(audioJump);
    }

    public void playRightStep()
    {
        rightStep.Play();
        Debug.Log(rightStep);
    }

    public void playLeftStep()
    {
        leftStep.Play();
        Debug.Log(leftStep);
    }

	IEnumerator AnswerCorrectTime(){


		yield return new WaitForSeconds(0.8f);

		camfinal.SetActive(false);
		campantalla.SetActive(false);


		//-----------calcular promedio
		puntos = EstadojuegoNivelProgra.score;


		//notafinal
		float puntajeSinPrueba = puntos + 30; //se le resta la respuesta incorrecta 

		notaFinal = ((0.075f) * (puntajeSinPrueba - 60)) + 4;

		//verificacion
		Debug.Log(puntos.ToString());





		if (notaFinal >= 1) {
			if (notaFinal >= 4)
			{
				camyes.SetActive(true);
				portalyes.SetActive(true);
				CanvasAprob.SetActive(true);
				TextAprob.text = notaFinal.ToString();
			}
			else if (notaFinal < 4)
			{
				camfail.SetActive(true);



				portalfail.SetActive(true);
				CanvasReprob.SetActive(true);
				TextReprob.text = notaFinal.ToString();
			}
		} else if (notaFinal < 1){
			camfail.SetActive(true);



			portalfail.SetActive(true);
			CanvasReprob.SetActive(true);
			TextReprob.text = "1";
		}


		//--------------termino de calculo.

		yield return new WaitForSeconds(3.5f);

		if (CanvasAprob.activeSelf==true)
		{
			CanvasAprob.SetActive(false);

		}
		else {
			CanvasReprob.SetActive(false);
		}

		campantalla.SetActive(false);
		camfail.SetActive(false);
		camyes.SetActive(false);
		camfinal.SetActive(true);

		yield return new WaitForSeconds(2.2f);

		//m_Animator.SetBool("IsInteract",false);





	}


	IEnumerator AnswerInCorrectTime(){


		yield return new WaitForSeconds(0.8f);

		camfinal.SetActive(false);
		campantalla.SetActive(false);
		camfail.SetActive(true);



		portalfail.SetActive(true);


		//-----------calcular promedio
		puntos = EstadojuegoNivelProgra.score;


		//notafinal
		float puntajeSinPrueba = puntos - 30; //se le resta la respuesta incorrecta 

		notaFinal = ((0.075f) * (puntajeSinPrueba - 60)) + 4;

		//verificacion
		Debug.Log(puntos.ToString());


		if (notaFinal >= 1)
		{
			if (notaFinal >= 4)
			{
				camyes.SetActive(true);
				portalyes.SetActive(true);
				CanvasAprob.SetActive(true);
				TextAprob.text = notaFinal.ToString();
			}
			else if (notaFinal < 4)
			{
				camfail.SetActive(true);



				portalfail.SetActive(true);
				CanvasReprob.SetActive(true);
				TextReprob.text = notaFinal.ToString();
			}
		}
		else if (notaFinal < 1)
		{
			camfail.SetActive(true);



			portalfail.SetActive(true);
			CanvasReprob.SetActive(true);
			TextReprob.text = "1";
		}


		//--------------termino de calculo.

		yield return new WaitForSeconds(3.5f);
		if (CanvasAprob == true)
		{
			CanvasAprob.SetActive(false);

		}
		else
		{
			CanvasReprob.SetActive(false);
		}

		CanvasReprob.SetActive(false);

		campantalla.SetActive(false);
		camfail.SetActive(false);
		camyes.SetActive(false);
		camfinal.SetActive(true);

		yield return new WaitForSeconds(2.2f);

		//m_Animator.SetBool("IsInteract",false);



	}






}

