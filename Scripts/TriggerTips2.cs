using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Invector.CharacterController;
using UnityStandardAssets.Characters.ThirdPerson;

public class TriggerTips2 : MonoBehaviour {

	public GameObject INACAPO;
	private Animator INACAPOanim;
	public GameObject interactTips;
	public GameObject continuarTips;
	public GameObject TipsCANVAS;
	private Text[] TipsText;
	public bool lockCursor = true;


	public static bool isTips;


	void Start() {


		INACAPOanim = INACAPO.GetComponent<Animator>();
		//TipsText = TipsCANVAS.GetComponentsInChildren<Text>();
	}

	void OnTriggerStay() {

		interactTips.SetActive(true);



	}


	void OnTriggerExit()
	{


		interactTips.SetActive(false);


	}



	public void DisplayTips() {


		interactTips.SetActive(false);
		continuarTips.SetActive(true);

		lockCursor = !lockCursor;
		Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
		Cursor.visible = !lockCursor;

		Time.timeScale = 0;


		TipsCANVAS.SetActive(true);

		//TipsText [0].text = "tip2";
		//TipsText [1].text = "tip2";



		//Text TipsText = Tips.GetComponent<Text>();
		//TipsText.text = sentence;
		//Debug.Log(tipsentences.sentence);



		//isTips = true;
		//INACAPOanim.SetBool("IsInteract", true);
		//FindObjectOfType<ThirdPersonCharacter> ().isStop = true;
		//FindObjectOfType<vThirdPersonController> ().lockMovement = true;


	}


	public void ContinueTips(){

		lockCursor = !lockCursor;


		Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
		Cursor.visible = lockCursor;
		continuarTips.SetActive(false);

		TipsCANVAS.SetActive(false);
		Time.timeScale = 1;


	}


}
