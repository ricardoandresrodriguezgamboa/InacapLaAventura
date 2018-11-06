using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_errorcompile : MonoBehaviour {

	private int color = 0;	//color 0 rojo, color 1 azul
	private enemy eInstance;

	// Use this for initialization
	void Awake () {

		eInstance = FindObjectOfType<enemy> ();
		StartCoroutine(Patron());

	
		
	}
	
	// Update is called once per frame
	void Update () {
		


	

		
	}


	void OnTriggerEnter(Collider other){


		if (other.gameObject.CompareTag("Inacapin")) {

			if (color==0) {

				StartCoroutine(eInstance.DeathScene3());
				Debug.Log("Dead");

			}

			
		}
	


	}


	void OnTriggerStay(Collider other){
			
		if (other.gameObject.CompareTag("Inacapin")) {

			if (color==0) {

				StartCoroutine(eInstance.DeathScene3());
				Debug.Log("Dead");


			}


		}

	}




	IEnumerator Patron(){
		
		Renderer ColorPlatform = this.GetComponent<Renderer>();

		Color color1 = new Color(1,0,0);
		Color32 color1E = new Color32(58,0,0,0);

		Color color2 = new Color(0,0,1);
		Color32 color2E = new Color32(0,3,58,0);



		while (true) {
			
 
			ColorPlatform.material.shader = Shader.Find ("Standard");
			ColorPlatform.material.SetColor ("_Color", color1);
			ColorPlatform.material.SetColor ("_EmissionColor", color1E);

			yield return new WaitForSeconds (3);

			color = 1;

			ColorPlatform.material.shader = Shader.Find ("Standard");
			ColorPlatform.material.SetColor ("_Color", color2);
			ColorPlatform.material.SetColor ("_EmissionColor", color2E);

			yield return new WaitForSeconds (3);

			color = 0;
 
		}
 
 


	}





}
