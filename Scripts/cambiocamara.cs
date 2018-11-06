using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;
using UnityStandardAssets.Characters.ThirdPerson;

public class cambiocamara : MonoBehaviour {

	public GameObject camentrada;
	public GameObject camprincipal;
    public GameObject Inacapin;
    
    // Use this for initialization
    void Start () {

		FindObjectOfType<vThirdPersonController> ().lockMovement = true;
		FindObjectOfType<ThirdPersonCharacter> ().isStop = true;
		StartCoroutine (time ());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}





	IEnumerator time(){


		yield return new WaitForSeconds(4.6f);
		camentrada.SetActive(false);
		camprincipal.SetActive(true);
        Inacapin.SetActive(true);


        FindObjectOfType<vThirdPersonController> ().lockMovement = false;
		FindObjectOfType<ThirdPersonCharacter> ().isStop = false;

	}
	
}
