using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour {

	 
	private Animator DoorAnim;


	void Awake(){

		DoorAnim = this.GetComponent<Animator> ();
	
	}

	 
	void OnTriggerEnter(){


		DoorAnim.SetBool("IsOpen",true);


		//Debug.Log ("Door Open");
	
	
	}


	void OnTriggerExit(){

		//DoorAnim.SetBool("IsOpen",false);
		//Debug.Log ("Door Close");

	}
}
