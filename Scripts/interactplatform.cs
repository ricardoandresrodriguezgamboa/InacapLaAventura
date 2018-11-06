using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class interactplatform : MonoBehaviour {
 
	public GameObject buttoninteract;
	public GameObject camfinal;
	public GameObject camsecundaria;
	public GameObject INACAPO;
	private Animator INACAPOanim;
	private int ccount=0;


	void Start(){


		INACAPOanim = INACAPO.GetComponent<Animator>();
	}

 

	void OnTriggerStay (Collider other)
	{
	
	 
		buttoninteract.SetActive(true);
	
	}


	void OnTriggerExit (Collider other)
	{


		buttoninteract.SetActive(false);

	}


	public void interactaction(){

		ccount = ccount + 1;
 
		if (ccount == 1) {
			camfinal.SetActive (false);
			camsecundaria.SetActive (true);
			INACAPOanim.SetBool("IsInteract",true);
			//FindObjectOfType<ThirdPersonCharacter>().isStop = true;

		} else if (ccount == 2){
		
			camfinal.SetActive (true);
			camsecundaria.SetActive (false);
			INACAPOanim.SetBool("IsInteract",false);
			//FindObjectOfType<ThirdPersonCharacter>().isStop = false;
			ccount = 0;
  	
		}

	}

	 

}
