using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;
using UnityStandardAssets.Characters.ThirdPerson;

public class MoveSpin : MonoBehaviour {

	public float Movespeed;
	public static bool isSpin=false;
	private Rigidbody RigInacapo;
	private Animator INACAPOAnimator;
	public GameObject thirdpersoncontrollerINACAPO;
	public Camera camaraprincipal;
	private BoxCollider InacapoCol ;
	public AudioSource sourcespin;
	public AudioClip clipspin;


	// Use this for initialization
	void Start () {

		//sourcespin.clip = clipspin;
		Movespeed = 3.5f;
		InacapoCol = thirdpersoncontrollerINACAPO.GetComponent<BoxCollider> ();
		INACAPOAnimator =  thirdpersoncontrollerINACAPO.GetComponent<Animator> ();
		RigInacapo = thirdpersoncontrollerINACAPO.GetComponent<Rigidbody> ();
		
	}


	 
	
	// Update is called once per frame
	void Update () {

	/*	if (INACAPOAnimator.GetBool("IsSpinning")) {

			sourcespin.clip = clipspin;
			sourcespin.Play ();


			
		} else {
		
			//sourcespin.clip = clipspin;
			sourcespin.Stop ();
		
		}*/

		 


          if (Input.GetKey(KeyCode.LeftShift) && !triggerpc.isTalk || Input.GetButton("XBOX360_B") && !triggerpc.isTalk)
          {

		 
		
			//aire

			if (!FindObjectOfType<vThirdPersonController> ().isGrounded) {

 

				//FindObjectOfType<vThirdPersonController> ().lockMovement = false;
				FindObjectOfType<ThirdPersonCharacter> ().isStop = false;

				InacapoCol.enabled = true;
				//InacapoCol[1].enabled = true;
				INACAPOAnimator.SetBool ("IsSpinning", true);
				isSpin = true;
			 

			} else {

			 

				InacapoCol.enabled = false;
				//InacapoCol[1].enabled = false;
				INACAPOAnimator.SetBool ("IsSpinning", false);
				isSpin = false;


			
			}  

			//suelo

			if (FindObjectOfType<vThirdPersonController> ().isGrounded) {


				//sourcespin.Play();
				 
				//FindObjectOfType<vThirdPersonController> ().lockMovement = true;
				FindObjectOfType<ThirdPersonCharacter> ().isStop = true;

				InacapoCol.enabled = true;
				//InacapoCol[1].enabled = true;
				INACAPOAnimator.SetBool ("IsSpinning", true);

				isSpin = true;

				Vector3 right = camaraprincipal.transform.right;


				Vector3 forward = Vector3.Cross (right, Vector3.up);


				Vector3 movement = Vector3.zero;
				movement += right * (Input.GetAxis ("Horizontal") * Movespeed * Time.deltaTime);
				movement += forward * (Input.GetAxis ("Vertical") * Movespeed * Time.deltaTime);


				transform.Translate (movement, Space.World);

			}
		
		} else {
			    

			    //sourcespin.Stop();
			 
				//FindObjectOfType<vThirdPersonController> ().lockMovement = false;
				FindObjectOfType<ThirdPersonCharacter> ().isStop = false;

		     	InacapoCol.enabled = false;
				//InacapoCol[1].enabled = false;
				INACAPOAnimator.SetBool("IsSpinning", false);
				isSpin = false;
				
		}
	}


 

}
 
