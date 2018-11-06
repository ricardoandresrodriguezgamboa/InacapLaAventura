using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Invector.CharacterController;


public class detectarxboxcontrol : MonoBehaviour {


	public RawImage interact;
	public Texture interactxbox360;
	public Texture interactpc;
	//public RuntimeAnimatorController interactanim;


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
 
		for (int i = 0; i < Input.GetJoystickNames ().Length; i++) {
			if (Input.GetJoystickNames () [i] == "") { // no hay ningun control

			 
				FindObjectOfType<vThirdPersonInput> ().sprintInput = KeyCode.None;
				FindObjectOfType<vThirdPersonInput> ().strafeInput = KeyCode.Tab;
				FindObjectOfType<vThirdPersonInput> ().jumpInput = KeyCode.Space;
				FindObjectOfType<vThirdPersonInput> ().rotateCameraXInput = "mouse x";
				FindObjectOfType<vThirdPersonInput> ().rotateCameraYInput = "mouse y";
				interact.texture = (Texture)interactpc;
				interact.GetComponent<RectTransform>().sizeDelta = new Vector2 (35,25);
				 

			} else {

				FindObjectOfType<vThirdPersonInput> ().sprintInput = KeyCode.None;
				FindObjectOfType<vThirdPersonInput> ().strafeInput = KeyCode.Joystick1Button4;
				FindObjectOfType<vThirdPersonInput> ().jumpInput = KeyCode.Joystick1Button0;
				FindObjectOfType<vThirdPersonInput> ().rotateCameraXInput = "JoyX";
				FindObjectOfType<vThirdPersonInput> ().rotateCameraYInput = "JoyY";
				interact.texture = (Texture)interactxbox360;
				interact.GetComponent<RectTransform>().sizeDelta = new Vector2 (27,27);
			  
				//interact.GetComponent<Animator> ().runtimeAnimatorController = interactanim as RuntimeAnimatorController;

			}
	}
}
}