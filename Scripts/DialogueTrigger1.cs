﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController; 
using UnityStandardAssets.Characters.ThirdPerson;


public class DialogueTrigger1 : MonoBehaviour {


	public Dialogue dialogue;
	public bool DialogoActivo = false;
	public GameObject interact;
	public GameObject interacttalk;
	public bool returnpressed=false;
 




 

	public static DialogueTrigger1 instance;

	// Use this for initialization
	void Start () {
		instance = this;
		interact.SetActive (false);
		interacttalk.SetActive (true);


	}

	
	// Update is called once per frame
	void Update () {
 
		
	}



	void OnTriggerEnter (Collider other){
 
 
		 
		 	interact.SetActive (true);
  

	}




	void OnTriggerStay(Collider other)
	{	
			


		if (Input.GetKeyDown (KeyCode.Return) && returnpressed == false || Input.GetButton("Interact")  && DialogoActivo == false) {

 
		
			returnpressed = true;

		
			GameObject Inacapin = GameObject.FindGameObjectWithTag("Inacapin");

 

			Rigidbody InacapinRig = Inacapin.GetComponent<Rigidbody>();
			Animator InacapinAnim = Inacapin.GetComponent<Animator>();

		


			InacapinAnim.SetBool("IsInteract",true);
		
			InacapinRig.isKinematic = true;

	 

			FindObjectOfType<ThirdPersonCharacter> ().isStop = true;
			FindObjectOfType<vThirdPersonController> ().lockMovement = true;

			interact.SetActive (false);
			interacttalk.SetActive (false);
			DialogoActivo = true;
			FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);

		}
	
	}


	void OnTriggerExit(Collider other)
	{

		interact.SetActive (false);
		interacttalk.SetActive (true);
		returnpressed = false;
	 


	}
}
