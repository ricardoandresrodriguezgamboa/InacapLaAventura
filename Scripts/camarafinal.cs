using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarafinal : MonoBehaviour {



	public GameObject camprincipal;
	public GameObject camfinal;





	void OnTriggerEnter (Collider other)
	{

		camprincipal.SetActive(false);
		camfinal.SetActive(true);

	}

}
