using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DialogueTriggerOLD : MonoBehaviour {

	public Dialogue dialogue;
	public Dialogue2 dialogue2;
	public Dialogue3 dialogue3;
	public GameObject ThirdPersonController;
	public GameObject interact;
	public GameObject interacttalk;
	public GameObject interacttalk2;
	public GameObject interacttalk3;
	public int count=0;
	public int count2=0;
	public static DialogueTriggerOLD instance;



	void Start(){
		instance = this;

	}

	/*void Update(){
		
 

		//posicion thirdperson

		if (ThirdPersonController.transform.position.z > 3.0 && ThirdPersonController.transform.position.z < 3.5 && ThirdPersonController.transform.position.x > 1.9 && ThirdPersonController.transform.position.x < 2.8 && ThirdPersonController.transform.position.y < 1.8 ) {

		
			if (count2 != 1) {
				interact.SetActive (true);
			
			}




			if (Input.GetKeyDown (KeyCode.Return) || Input.GetButton("Interact")) {

				interact.SetActive (false);
				interacttalk.SetActive (false);
				count2 = 1;




				if (count != 1) {
			
					FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);
					count = 1;
				} else {
				
					//Debug.Log ("No dialogo");
					//Debug.Log (count);

				} 
			

			}
				

			//ThirdPersonController.transform.position.z > 24.5 && ThirdPersonController.transform.position.z < 26.4 && ThirdPersonController.transform.position.x > 6.8 && ThirdPersonController.transform.position.x < 8.8

		}else if(ThirdPersonController.transform.position.z > 24.5 && ThirdPersonController.transform.position.z < 26.4 && ThirdPersonController.transform.position.x > 6.8 && ThirdPersonController.transform.position.x < 8.8 && ThirdPersonController.transform.position.y < 2.1){
				

				if (count2 != 1) {
					interact.SetActive (true);

				}


			if (Input.GetKeyDown (KeyCode.Return)  || Input.GetButton("Interact") ) {

				interact.SetActive (false);
				interacttalk2.SetActive (false);
				count2 = 1;

			

				if (count != 1) {

					FindObjectOfType<DialogueManager> ().StartDialogue2 (dialogue2);
					count = 1;
				} else {

					//Debug.Log ("No dialogo");
					//Debug.Log (count);

				} 


			}



		}else if(ThirdPersonController.transform.position.z > 36.3 && ThirdPersonController.transform.position.z < 38.5 && ThirdPersonController.transform.position.x > 7.7 && ThirdPersonController.transform.position.x < 8.9 && ThirdPersonController.transform.position.y < 2.1){

			if (count2 != 1) {
				interact.SetActive (true);

			}


			if (Input.GetKeyDown (KeyCode.Return)  || Input.GetButton("Interact") ) {

				interact.SetActive (false);
				interacttalk3.SetActive (false);
				count2 = 1;



				if (count != 1) {

					FindObjectOfType<DialogueManager> ().StartDialogue3 (dialogue3);
					count = 1;
				} else {

					//Debug.Log ("No dialogo");
					//Debug.Log (count);

				} 


			}


		}else {
			interact.SetActive (false);
			interacttalk.SetActive (true);
			interacttalk2.SetActive (true);
			interacttalk3.SetActive (true);

		}

	}*/



		 
	
	
}
