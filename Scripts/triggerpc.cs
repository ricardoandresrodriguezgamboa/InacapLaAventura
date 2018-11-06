using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController; 
using UnityStandardAssets.Characters.ThirdPerson;

public class triggerpc : MonoBehaviour {

	public Dialogue5 dialogue5;
	public static bool isTalk=false;
	public bool DialogoActivo = false;
	public GameObject buttoninteractpc;
	public GameObject Inacapo;
	private Animator InacapoAnimator;
	private Rigidbody InacapoRig;
	public bool returnpressed=false;

	public static triggerpc instance;


	void Start(){

		instance = this;
		InacapoAnimator = Inacapo.GetComponent<Animator>();
		InacapoRig = Inacapo.GetComponent<Rigidbody>();
		buttoninteractpc.SetActive (false);
	
	}

	void OnTriggerEnter(Collider other){

        if (other.CompareTag("Inacapin"))
        {
            buttoninteractpc.SetActive(true);
        }

		
  		
	}


    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Inacapin"))
        {
			if (Input.GetKeyDown(KeyCode.Return) && returnpressed==false || Input.GetButton("Interact") && DialogoActivo == false)
            {

				returnpressed = true;
                isTalk = true;

				InacapoAnimator.SetBool("IsSpinning", false);
        
              

				InacapoAnimator.SetBool("IsInteract",true);
				InacapoRig.isKinematic = true;

				FindObjectOfType<ThirdPersonCharacter>().isStop = true;
				FindObjectOfType<vThirdPersonController>().lockMovement = true;




                buttoninteractpc.SetActive(false);

                DialogoActivo = true;
                FindObjectOfType<DialogueManager>().StartDialogue5(dialogue5);

            }
        }
	}


	void OnTriggerExit(Collider other){

        if (other.CompareTag("Inacapin"))
        {
            buttoninteractpc.SetActive(false);
			returnpressed = false;
        }

	}
}
