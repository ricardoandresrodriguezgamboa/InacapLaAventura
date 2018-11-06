using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Invector.CharacterController;


public class detectarxboxcontrol2 : MonoBehaviour {

 
	public GameObject INACAPO;


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		for (int i = 0; i < Input.GetJoystickNames ().Length; i++) {
			if (Input.GetJoystickNames () [i] == "") { // no hay ningun control
				
 

				if (INACAPO.activeSelf!=false) {

					FindObjectOfType<vThirdPersonInput> ().sprintInput = KeyCode.None;
					FindObjectOfType<vThirdPersonInput> ().strafeInput = KeyCode.None;
					FindObjectOfType<vThirdPersonInput> ().jumpInput = KeyCode.Space;
					FindObjectOfType<vThirdPersonInput> ().rotateCameraXInput = "mouse x";
					FindObjectOfType<vThirdPersonInput> ().rotateCameraYInput = "mouse y";
				}

			}else {

				if (INACAPO.activeSelf!=false) {

					FindObjectOfType<vThirdPersonInput> ().sprintInput = KeyCode.None;
					FindObjectOfType<vThirdPersonInput> ().strafeInput = KeyCode.None;
					FindObjectOfType<vThirdPersonInput> ().jumpInput = KeyCode.Joystick1Button0;
					FindObjectOfType<vThirdPersonInput> ().rotateCameraXInput = "JoyX";
					FindObjectOfType<vThirdPersonInput> ().rotateCameraYInput = "JoyY";

				}

 
				//interact.GetComponent<Animator> ().runtimeAnimatorController = interactanim as RuntimeAnimatorController;

			}
		}
	}
}
