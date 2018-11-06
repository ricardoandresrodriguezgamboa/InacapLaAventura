using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEnemy : MonoBehaviour {
	
	public int pushPower;

	void OnControllerColliderHit(ControllerColliderHit  hit){

		if (hit.gameObject.CompareTag("virususb")) {


			Rigidbody body = hit.collider.attachedRigidbody;

			if(body == null || body.isKinematic){

				return;
			}

			if(hit.moveDirection.y < -0.3){
				return;	
			}

			Vector3 pushDir = new Vector3(hit.moveDirection.x,0,hit.moveDirection.z);

			body.velocity = pushDir * pushPower;

		}



	}
}
