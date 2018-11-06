using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;
using Invector.CharacterController; 

public class DialogueManager : MonoBehaviour {



	public Text NameText;
	public Text dialogueText;

	private Dialogue dialogue;
	public GameObject Inacapo;
	public GameObject sickpc;
	public GameObject healthypc;
	public AudioSource windowsClip;
	public AudioSource SoundPoint;
	public GameObject ContenedorHUD;
	public GameObject DialogueBox; 
	public GameObject menu;
	public GameObject menucarreras;
	public GameObject cameradialogue;
	public GameObject cameradialogue2;
	public GameObject camerachef;
	public GameObject camerabushy;
	public GameObject camjefeinformatica;
	public GameObject continuar;
	public GameObject continuar2;
	public GameObject continuar3;
	public GameObject continuar4;
	public GameObject continuar5;
	public GameObject robotito;
	public GameObject MenuAsignatura;
	//public Button continuar_btn;
	//public Button continuar_btn2;
	//public Button continuar_btn3;
	public GameObject MenuDetallado;

	//Gastronomia

	public GameObject MenuGastronomia;
	public GameObject MenuGastronomiaMalla;
	public GameObject MenuGastronomiaDes;
	public GameObject MenuGastronomiaCampo;

	//Diseño


	public GameObject MenuDiseno;
	public GameObject MenuDisenoMalla;
	public GameObject MenuDisenoDes;
	public GameObject MenuDisenoCampo;

	//Informatica


	public GameObject MenuInformatica;
	public GameObject MenuInformaticaMalla;
	public GameObject MenuInformaticaDes;
	public GameObject MenuInformaticaCampo;

	public GameObject sedes;
	public GameObject sobreinacap;
	public GameObject tutorial;

	public Text nombrecarrera;
	public Text nombreasignatura;

	public RawImage malla;
	public Texture mallainf;
	public Texture mallamec;
	public Texture mallaadm;
	public Texture malladis;
	public Texture mallasal;
	public Texture mallagas;

	//int contador=0;




	private Queue<string> sentences;



	// Use this for initialization
	void Start ()
	{
		sentences = new Queue<string> ();

	

		DialogueBox.SetActive (false);
		menu.SetActive (false);
		sedes.SetActive (false);
		sobreinacap.SetActive (false);
		menucarreras.SetActive (false);
		cameradialogue.SetActive (false);
		cameradialogue2.SetActive (false);
		camerachef.SetActive (false);
		camerabushy.SetActive (false);
		camjefeinformatica.SetActive (false);
		MenuAsignatura.SetActive (false);


		MenuDetallado.SetActive (false);
		

	}

	void Update(){
 

	}


	//-----------------------------------------dialogue 1----------------------------------------

	public bool lockCursor = true;

	public void StartDialogue(Dialogue dialogue){
	
		//Debug.Log("Start conversation with " + dialogue.name);
		//contador=1;
		ContenedorHUD.SetActive (false);

		lockCursor = !lockCursor;
		

		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;


		continuar.SetActive(false);
		continuar2.SetActive(false);
	
	

		cameradialogue.SetActive(true);


		//FindObjectOfType<ThirdPersonCharacter> ().isStop = true;
		Inacapo.GetComponent<Rigidbody>().velocity  =  Vector3.zero;

		FindObjectOfType<vThirdPersonController> ().lockMovement = true;
		
	
		DialogueBox.SetActive (true);


		NameText.text = dialogue.name;


		sentences.Clear ();


			
		foreach (string sentence in dialogue.sentences) {

			sentences.Enqueue (sentence);
	
		
		}
			

		DisplayNextSentence ();
		
	}


 

	  

	public void DisplayNextSentence(){

		continuar.SetActive(false);
		continuar2.SetActive(false);
		continuar3.SetActive(false);

		if(sentences.Count == 0){

	
			Debug.Log ("end1");
			EndDialogue();
			return;
		}


		string sentence = sentences.Dequeue();

	
 

		StopAllCoroutines();
		StartCoroutine (TypeSentence(sentence));
 
		

	}


	IEnumerator TypeSentence (string sentence){
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray()) {
			dialogueText.text += letter;
			yield return null;
		}

	
			
			continuar.SetActive(true);



	 
	 
	}

	public void EndDialogue(){

	 
		DialogueBox.SetActive(false);



		menu.SetActive(true);
		cameradialogue2.SetActive(true);
	

		//SceneManager.LoadScene("menu");
	
		//FindObjectOfType<ThirdPersonCharacter> ().isStop = false;

		 
	

	}


	public void menuSeleccion(Button buttonSelected){

		menu.SetActive (false);

		if (buttonSelected.name == "carreras") {

			menucarreras.SetActive (true);
		}

		if (buttonSelected.name == "sedes") {

			sedes.SetActive (true);
		}

		if (buttonSelected.name == "sobreinacap") {

			sobreinacap.SetActive (true);
		}

		if (buttonSelected.name == "tutorial") {

			//tutorial.SetActive (true);
		}





	}


	public void carreraDetallada(Button buttonSelected){

		FindObjectOfType<ThirdPersonCharacter> ().isStop = true;
		cameradialogue.SetActive(true);
		menucarreras.SetActive (false);


		if(buttonSelected.name == "informatica"){

			nombrecarrera.text = "Informática :";
			malla.texture = (Texture)mallainf;

			MenuDetallado.SetActive (true);



		}else if(buttonSelected.name == "mecanica"){

			nombrecarrera.text = "Mecánica :";
			malla.texture = (Texture)mallamec;
			MenuDetallado.SetActive (true);

		}else if(buttonSelected.name == "administracion"){

			nombrecarrera.text = "Administración :";
			malla.texture = (Texture)mallaadm;
			MenuDetallado.SetActive (true);

		}else if(buttonSelected.name == "diseñografico"){

			nombrecarrera.text = "Diseño gráfico :";
			malla.texture = (Texture)malladis;
			MenuDetallado.SetActive (true);

		}else if(buttonSelected.name == "salud"){

			nombrecarrera.text = "Salud :";
			malla.texture = (Texture)mallasal;
			MenuDetallado.SetActive (true);

		}else if(buttonSelected.name == "gastronomia"){

			nombrecarrera.text = "Gastronomía :";
			malla.texture = (Texture)mallagas;
			MenuDetallado.SetActive (true);

		}



	}

	public void backMenu(){



		MenuDetallado.SetActive (false);
		menucarreras.SetActive (true);



	}

	public void backmainmenu(){

		menucarreras.SetActive (false);
		menu.SetActive (true);

	}


	public void backmainmenu2(){
		sedes.SetActive (false);
		menu.SetActive (true);

	}


	public void backmainmenu3(){
		sobreinacap.SetActive (false);
		menu.SetActive (true);

	}




	public void returnScene(){

		menu.SetActive(false);
		cameradialogue.SetActive(false);
		cameradialogue2.SetActive (false);
		ContenedorHUD.SetActive (true);
 


		
		GameObject Inacapin = GameObject.FindGameObjectWithTag("Inacapin");

		Rigidbody InacapinRig = Inacapin.GetComponent<Rigidbody>();
		Animator InacapinAnim = Inacapin.GetComponent<Animator>();
		
		InacapinAnim.SetBool("IsInteract",false);

		InacapinRig.isKinematic = false;

		FindObjectOfType<ThirdPersonCharacter> ().isStop = false;
		FindObjectOfType<vThirdPersonController> ().lockMovement = false;

		

		//FindObjectOfType<DialogueTrigger1> ().IsTalk = false;
		//FindObjectOfType<vThirdPersonInput> ().rotateCameraXInput = "mouse x";
		//FindObjectOfType<vThirdPersonInput> ().rotateCameraYInput = "mouse y";


		lockCursor = false;
		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;

		DialogueTrigger1.instance.DialogoActivo = false;





	}



	//-----------------------------------------dialogue 2----------------------------------------



	public void StartDialogue2(Dialogue2 dialogue2){

		//Debug.Log("Start conversation with " + dialogue.name);

		//contador=1;

		ContenedorHUD.SetActive (false);

		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;

		continuar.SetActive(false);
		continuar2.SetActive(false);



		camerachef.SetActive(true);


		//FindObjectOfType<ThirdPersonCharacter> ().isStop = true;

		DialogueBox.SetActive (true);


		NameText.text = dialogue2.name;


		sentences.Clear ();



		foreach (string sentence in dialogue2.sentences) {

			sentences.Enqueue (sentence);


		}


		DisplayNextSentence2 ();

	}






	public void DisplayNextSentence2(){
		
		continuar.SetActive(false);
		continuar2.SetActive(false);
		continuar3.SetActive(false);

		if(sentences.Count == 0){


			Debug.Log ("end2");
			EndDialogue2();
			return;
		}


		string sentence = sentences.Dequeue();




		StopAllCoroutines();
		StartCoroutine (TypeSentence2(sentence));
	 


	}




	public void EndDialogue2(){


		DialogueBox.SetActive(false);
	 
		MenuGastronomia.SetActive(true);

		/*camerachef.SetActive(false);
		 
		GameObject Inacapin = GameObject.FindGameObjectWithTag("Inacapin");

		Rigidbody InacapinRig = Inacapin.GetComponent<Rigidbody>();
		Animator InacapinAnim = Inacapin.GetComponent<Animator>();

		InacapinAnim.SetBool("IsInteract",false);

		InacapinRig.isKinematic = false;

		FindObjectOfType<ThirdPersonCharacter> ().isStop = false;
		FindObjectOfType<vThirdPersonController> ().lockMovement = false;


 

		lockCursor = false;
		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;


		DialogueTrigger2.instance.DialogoActivo = false;*/
  
	}


	public void VerMalla(){

		MenuGastronomia.SetActive(false);
		MenuGastronomiaMalla.SetActive(true);

	}

	public void VerDescripcion(){

		MenuGastronomia.SetActive(false);
		MenuGastronomiaDes.SetActive(true);


	}

	public void VerCampo(){

		MenuGastronomia.SetActive(false);
		MenuGastronomiaCampo.SetActive(true);


	}

	public void backMenuGastronomia(){

		MenuGastronomiaMalla.SetActive(false);
		MenuGastronomiaDes.SetActive(false);
		MenuGastronomiaCampo.SetActive(false);
		MenuGastronomia.SetActive(true);
	

	}

	public void ExitMenuGastronomia(){
		
		MenuGastronomia.SetActive(false);
		ContenedorHUD.SetActive (true);

		camerachef.SetActive(false);
		 
		GameObject Inacapin = GameObject.FindGameObjectWithTag("Inacapin");

		Rigidbody InacapinRig = Inacapin.GetComponent<Rigidbody>();
		Animator InacapinAnim = Inacapin.GetComponent<Animator>();

		InacapinAnim.SetBool("IsInteract",false);

		InacapinRig.isKinematic = false;

		FindObjectOfType<ThirdPersonCharacter> ().isStop = false;
		FindObjectOfType<vThirdPersonController> ().lockMovement = false;


 

		lockCursor = false;
		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;


		DialogueTrigger2.instance.DialogoActivo = false;


	}



	IEnumerator TypeSentence2 (string sentence){
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray()) {
			dialogueText.text += letter;
			yield return null;
		}

		continuar2.SetActive(true);

		//Debug.Log("termino");

	}




	//-----------------------------------------dialogue 3----------------------------------------



	public void StartDialogue3(Dialogue3 dialogue3){

		//Debug.Log("Start conversation with " + dialogue.name);

		//contador=1;

		ContenedorHUD.SetActive (false);
		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;

		continuar.SetActive(false);
		continuar2.SetActive(false);
		continuar3.SetActive(false);


		camerabushy.SetActive(true);


		//FindObjectOfType<ThirdPersonCharacter> ().isStop = true;

		DialogueBox.SetActive (true);


		NameText.text = dialogue3.name;


		sentences.Clear ();



		foreach (string sentence in dialogue3.sentences) {

			sentences.Enqueue (sentence);


		}


		DisplayNextSentence3 ();

	}






	public void DisplayNextSentence3(){

		continuar.SetActive(false);
		continuar2.SetActive(false);
		continuar3.SetActive(false);

		if(sentences.Count == 0){


			Debug.Log ("end3");
			EndDialogue3();
			return;
		}


		string sentence = sentences.Dequeue();




		StopAllCoroutines();
		StartCoroutine (TypeSentence3(sentence));
		 


	}

	public void VerMalla2(){

		MenuDiseno.SetActive(false);
		MenuDisenoMalla.SetActive(true);

	}

	public void VerDescripcion2(){

		MenuDiseno.SetActive(false);
		MenuDisenoDes.SetActive(true);


	}

	public void VerCampo2(){

		MenuDiseno.SetActive(false);
		MenuDisenoCampo.SetActive(true);


	}

	public void backMenuDiseno(){

		MenuDisenoMalla.SetActive(false);
		MenuDisenoDes.SetActive(false);
		MenuDisenoCampo.SetActive(false);
		MenuDiseno.SetActive(true);


	}

	public void ExitMenuDiseno(){
	
		MenuDiseno.SetActive(false);
		camerabushy.SetActive(false);
		ContenedorHUD.SetActive (true);


		GameObject Inacapin = GameObject.FindGameObjectWithTag("Inacapin");

		Rigidbody InacapinRig = Inacapin.GetComponent<Rigidbody>();
		Animator InacapinAnim = Inacapin.GetComponent<Animator>();

		InacapinAnim.SetBool("IsInteract",false);

		InacapinRig.isKinematic = false;

		FindObjectOfType<ThirdPersonCharacter> ().isStop = false;
		FindObjectOfType<vThirdPersonController> ().lockMovement = false;


		lockCursor = false;
		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;


		DialogueTrigger3.instance.DialogoActivo = false;

	
	
	}




	public void EndDialogue3(){


		DialogueBox.SetActive(false);

		MenuDiseno.SetActive(true);
 


	}


	IEnumerator TypeSentence3 (string sentence){
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray()) {
			dialogueText.text += letter;
			yield return null;
		}

		continuar3.SetActive(true);

 

	}






//-----------------------------------------------Dialogue 4--------------------------------------------------------------


 

public void StartDialogue4(Dialogue4 dialogue4){

	//Debug.Log("Start conversation with " + dialogue.name);

	//contador=1;
	ContenedorHUD.SetActive (false);
	lockCursor = !lockCursor;


	Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
	Cursor.visible = !lockCursor;

	continuar.SetActive(false);
	continuar2.SetActive(false);
	continuar3.SetActive(false);
	continuar4.SetActive (false);


	camjefeinformatica.SetActive(true);


	//FindObjectOfType<ThirdPersonCharacter> ().isStop = true;

	DialogueBox.SetActive (true);


	NameText.text = dialogue4.name;


	sentences.Clear ();



	foreach (string sentence in dialogue4.sentences) {

		sentences.Enqueue (sentence);


	}


	DisplayNextSentence4 ();

}






public void DisplayNextSentence4(){

	continuar.SetActive(false);
	continuar2.SetActive(false);
	continuar3.SetActive(false);
	continuar4.SetActive(false);

	if(sentences.Count == 0){


		Debug.Log ("end4");
		EndDialogue4();
		return;
	}


	string sentence = sentences.Dequeue();




	StopAllCoroutines();
	StartCoroutine (TypeSentence4(sentence));



}

	public void VerMalla3(){

		MenuInformatica.SetActive(false);
		MenuInformaticaMalla.SetActive(true);

	}

	public void VerDescripcion3(){

		MenuInformatica.SetActive(false);
		MenuInformaticaDes.SetActive(true);


	}

	public void VerCampo3(){

		MenuInformatica.SetActive(false);
		MenuInformaticaCampo.SetActive(true);


	}

	public void backMenuInformatica(){

		MenuInformaticaMalla.SetActive(false);
		MenuInformaticaDes.SetActive(false);
		MenuInformaticaCampo.SetActive(false);
		MenuInformatica.SetActive(true);


	}

	public void ExitMenuInformatica(){

		MenuInformatica.SetActive(false);
		camjefeinformatica.SetActive(false);

		ContenedorHUD.SetActive (true);
 

		GameObject Inacapin = GameObject.FindGameObjectWithTag("Inacapin");

		Rigidbody InacapinRig = Inacapin.GetComponent<Rigidbody>();
		Animator InacapinAnim = Inacapin.GetComponent<Animator>();

		InacapinAnim.SetBool("IsInteract",false);

		InacapinRig.isKinematic = false;

		FindObjectOfType<ThirdPersonCharacter> ().isStop = false;
		FindObjectOfType<vThirdPersonController> ().lockMovement = false;


		lockCursor = false;
		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
		Cursor.visible = !lockCursor;


		DialogueTrigger4.instance.DialogoActivo = false;

	
	
	}




public void EndDialogue4(){


	DialogueBox.SetActive(false);
	
	MenuInformatica.SetActive (true);


	 




}


IEnumerator TypeSentence4 (string sentence){
	dialogueText.text = "";
	foreach (char letter in sentence.ToCharArray()) {
		dialogueText.text += letter;
		yield return null;
	}

	continuar4.SetActive(true);



}

//-----------------------------------------------Dialogue 5--------------------------------------------------------------




public void StartDialogue5(Dialogue5 dialogue5){

	//Debug.Log("Start conversation with " + dialogue.name);

	//contador=1;

	lockCursor = !lockCursor;


	Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
	Cursor.visible = !lockCursor;

	continuar5.SetActive(false);

 

	//FindObjectOfType<ThirdPersonCharacter> ().isStop = true;

	DialogueBox.SetActive (true);


	NameText.text = dialogue5.name;


	sentences.Clear ();



	foreach (string sentence in dialogue5.sentences) {

		sentences.Enqueue (sentence);


	}


	DisplayNextSentence5 ();

}






public void DisplayNextSentence5(){

	continuar5.SetActive(false);

	if(sentences.Count == 0){


		Debug.Log ("end5");
		EndDialogue5();
		return;
	}


	string sentence = sentences.Dequeue();




	StopAllCoroutines();
	StartCoroutine (TypeSentence5(sentence));



}




public void EndDialogue5(){


	DialogueBox.SetActive(false);
 
 

	lockCursor = false;
	lockCursor = !lockCursor;


	Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
	Cursor.visible = !lockCursor;


	triggerpc.instance.DialogoActivo = false;
	//triggerpc.isTalk = false;

	StartCoroutine(transformPC());

	GameObject Inacapin = GameObject.FindGameObjectWithTag("Inacapin");

	Rigidbody InacapinRig = Inacapin.GetComponent<Rigidbody>();
	Animator InacapinAnim = Inacapin.GetComponent<Animator>();

	InacapinAnim.SetBool("IsInteract",false);
	InacapinRig.isKinematic = false;

	FindObjectOfType<ThirdPersonCharacter>().isStop = false;
	FindObjectOfType<vThirdPersonController>().lockMovement = false;
 

}


IEnumerator TypeSentence5 (string sentence){
	dialogueText.text = "";
	foreach (char letter in sentence.ToCharArray()) {
		dialogueText.text += letter;
		yield return null;
	}

	continuar5.SetActive(true);



}



IEnumerator transformPC(){


	windowsClip.Play ();
	yield return new WaitForSeconds(1.5f);
	sickpc.SetActive(false);
	healthypc.SetActive(true);
	triggerpc.isTalk = false;
	SoundPoint.Play ();
	EstadojuegoNivelProgra.puntuacionPC = 10;
 	
	Animator ContenedorHUDanim = ContenedorHUD.GetComponent<Animator>();

	ContenedorHUDanim.Play("HUDanimation");
	//SUMAR 10 PUNTOS
	
}


	 

}
