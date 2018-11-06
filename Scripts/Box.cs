using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {



	void OnTriggerEnter (Collider other)
	{	
		//Animator INACAPOanim = Player.GetComponent<Animator> ();

		//INACAPOanim.Play ("Jump");

		if (other.gameObject.CompareTag ("Inacapin")) {

			//FindObjectOfType<ThirdPersonUserControl> ().m_Jump = true;

		/*	if (FindObjectOfType<ThirdPersonUserControl> ().m_Jump) {


			}*/

 
			GameObject Box = this.transform.parent.gameObject;

			Box.GetComponent<Collider> ().isTrigger = true;

			Animation boxAnimation = Box.GetComponent<Animation> ();
			//boxAnimation.enabled = true;
			//boxAnimation.playAutomatically = true;

		if (!boxAnimation.isPlaying) {
				boxAnimation.Play ();
				Destroy (this);
			}
		}

 

	}
}
