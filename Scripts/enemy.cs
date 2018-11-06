using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Invector.CharacterController;
using UnityStandardAssets.Characters.ThirdPerson;

public class enemy : MonoBehaviour {

	public GameObject Inacapo;
	public GameObject estadojuegoobject;
	public GameObject ContenedorHUD;
	public GameObject DeadAnimation;
	public AudioClip audioFall;
	public AudioClip audiogameover;
	public AudioSource audioFallSource;
    public AudioClip audioBugKill;
	public AudioSource source;
    public AudioSource sourcebugKill;
	public GameObject camprincipal;
	public GameObject camsecreto;
	public GameObject campantalla;
	public GameObject camfinal;
	public GameObject cammuerte;
    public AudioSource audioDeath;
	//public Animator INACAPOanim;
	//public GameObject camyes;
	//public GameObject camfail;
	public GameObject gameover;
	public Text txtvidas;
	private Rigidbody enemyrigid;
	private Animator enemyanim;
	//private Collider[] colNames;
	//private int random;
	public bool lockCursor = true;

 
	public bool enemykill=false;


	[SerializeField] private Transform RespawnPoint;
	[SerializeField] private Transform RespawnPoint2;
	[SerializeField] private Transform RespawnPoint3;
	[SerializeField] private Transform RespawnPoint4;
	[SerializeField] private Transform RespawnPoint5;
	[SerializeField] private Transform RespawnPoint6;
	//[SerializeField] private Transform DeadPosition;


	void Start(){

		  enemyrigid = this.GetComponent<Rigidbody>();
		  enemyanim = this.GetComponent<Animator>();


	
			
		
		  //INACAPOanim =  Inacapo.GetComponent<Animator>();
		  

	}

 

	void OnCollisionEnter(Collision other){
	
		if (other.gameObject.CompareTag ("Inacapin")) {
			
 

		/*foreach (ContactPoint contact in other.contacts)
			{
				Debug.DrawRay(contact.point, contact.normal, Color.red);
				Debug.Log(contact.point);
			}*/



			//enemyrigid.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

			if (MoveSpin.isSpin) {

				/*ContactPoint contact = other.contacts [0];
				Vector3 hitpoint = contact.point;
				Debug.Log (hitpoint);*/
 				
			    	enemykill = true;

					if (!this.gameObject.CompareTag ("virus1") || !this.gameObject.CompareTag ("virus2") || !this.gameObject.CompareTag ("virus3")) {

						if (this.gameObject.CompareTag("bug") || this.gameObject.CompareTag("bug2") || this.gameObject.CompareTag("bug3") || this.gameObject.CompareTag("bug4") || this.gameObject.CompareTag("bug6"))
						{
							//Debug.Log("chinita");

							enemyrigid.isKinematic = false;
							StartCoroutine(KillBUG());

						}else{
						
							//Debug.Log("usb");
							enemyrigid.isKinematic = false;
							enemyanim.enabled = false;
							//enemyrigid.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
							StartCoroutine(KillUSB());

						}

					} 
					

		

				
			} else {

			// StartCoroutine(DeathScene());
				    
				if (!enemykill) {

					if (this.gameObject.CompareTag("bug6"))
					{
						StartCoroutine(DeathScene2());
					}
					else
					{
						StartCoroutine(DeathScene());
					}
					
				}
 
          
			}
		} 
	
	}
 

   IEnumerator KillUSB() {


        //enemyrigid.constraints = RigidbodyConstraints.None | RigidbodyConstraints.None | RigidbodyConstraints.None;
        enemyrigid.AddForce(transform.up * 2500, ForceMode.Acceleration);


        yield return new WaitForSeconds(3);

       // this.gameObject.SetActive(false);
		Destroy(this.gameObject);
    
    
    }

    IEnumerator KillBUG() {
        
        //enemyrigid.constraints = RigidbodyConstraints.None | RigidbodyConstraints.None | RigidbodyConstraints.None;

        sourcebugKill.clip = audioBugKill;
        sourcebugKill.Play();
        enemyrigid.AddForce(transform.forward * 1000, ForceMode.Acceleration);

        
       
        yield return new WaitForSeconds(1);

		Destroy(this.gameObject);

      //  this.gameObject.SetActive(false);

    
    }

   


	IEnumerator DeathScene(){
  



		Inacapo.SetActive(false);
		//Inacapo.transform.position = DeadPosition.transform.position;
		//FindObjectOfType<vThirdPersonController> ().lockMovement = true;
		//FindObjectOfType<ThirdPersonCharacter> ().isStop = true;
		///INACAPOanim.SetBool("IsDead",true);
	 
	    camprincipal.SetActive(false);
		//camsecreto.SetActive(false);
		campantalla.SetActive (false);
		camfinal.SetActive(false);
		//camyes.SetActive(false);
		//camfail.SetActive(false);


		DeadAnimation.SetActive(true);
		cammuerte.SetActive(true);
        audioDeath.Play();

 

		restarvidas2();
 

		//Debug.Log("ok");

		yield return new WaitForSeconds(4);

	 
		//Debug.Log("ok2");

		//INACAPOanim.SetBool("IsDead",false);
		DeadAnimation.SetActive(false);
		cammuerte.SetActive(false);

		camprincipal.SetActive(true);
		//camsecreto.SetActive(true);
		campantalla.SetActive (true);
		camfinal.SetActive(true);
		//camyes.SetActive(true);
		//camfail.SetActive(true);


		Inacapo.SetActive(true);

	 

		if (this.gameObject.CompareTag("virususb")) {

			Inacapo.transform.position = RespawnPoint.transform.position;

		}else if(this.gameObject.CompareTag("bug")){

			Inacapo.transform.position = RespawnPoint.transform.position;

		}else if(this.gameObject.CompareTag("bug2")){

			Inacapo.transform.position = RespawnPoint2.transform.position;

		}
        else if (this.gameObject.CompareTag("bug3"))
        {

            Inacapo.transform.position = RespawnPoint3.transform.position;

        }
        else if (this.gameObject.CompareTag("bug4"))
        {

            Inacapo.transform.position = RespawnPoint4.transform.position;

        }
        else if (this.gameObject.CompareTag("virus1"))
        {

            Inacapo.transform.position = RespawnPoint.transform.position;


        }
        else if (this.gameObject.CompareTag("virus2"))
        {

            Inacapo.transform.position = RespawnPoint2.transform.position;

        }
        else if (this.gameObject.CompareTag("virus3"))
        {

            Inacapo.transform.position = RespawnPoint4.transform.position;

        }
	 
		//enemycol.isTrigger = true;
 

	}


    IEnumerator DeathScene2()
    {


        Inacapo.SetActive(false);



        //camprincipal.SetActive(false);
        camsecreto.SetActive(false);
        campantalla.SetActive(false);
        camfinal.SetActive(false);
       // camyes.SetActive(false);
        //camfail.SetActive(false);


        DeadAnimation.SetActive(true);
        cammuerte.SetActive(true);
        audioDeath.Play();


        restarvidas2();


        //Debug.Log("ok3");

        yield return new WaitForSeconds(4);


        //Debug.Log("ok4");


        DeadAnimation.SetActive(false);
        cammuerte.SetActive(false);

		camsecreto.SetActive(true);
		campantalla.SetActive(false);
		camfinal.SetActive(false);
        //camyes.SetActive(true);
        //camfail.SetActive(true);


        Inacapo.SetActive(true);

 
        Inacapo.transform.position = RespawnPoint6.transform.position;

        


    }


	public IEnumerator DeathScene3(){

	 


		Inacapo.SetActive(false);


		camprincipal.SetActive(false);

		campantalla.SetActive (false);
		camfinal.SetActive(false);


		DeadAnimation.SetActive(true);
		cammuerte.SetActive(true);
		audioDeath.Play();



		restarvidas2();



		yield return new WaitForSeconds(4);


		DeadAnimation.SetActive(false);
		cammuerte.SetActive(false);

		camprincipal.SetActive(true);

		campantalla.SetActive (true);
		camfinal.SetActive(true);



		Inacapo.SetActive(true);



		Inacapo.transform.position = RespawnPoint2.transform.position;





	}


	public IEnumerator DeathScene4(){




		Inacapo.SetActive(false);


		camprincipal.SetActive(false);

		campantalla.SetActive (false);
		camfinal.SetActive(false);


		DeadAnimation.SetActive(true);
		cammuerte.SetActive(true);
		audioDeath.Play();



		restarvidas2();



		yield return new WaitForSeconds(4);


		DeadAnimation.SetActive(false);
		cammuerte.SetActive(false);

		camprincipal.SetActive(true);

		campantalla.SetActive (true);
		camfinal.SetActive(true);



		Inacapo.SetActive(true);



		Inacapo.transform.position = RespawnPoint.transform.position;





	}



	public void restarvidas2(){

		Animator ContenedorHUDanim = ContenedorHUD.GetComponent<Animator>();

		ContenedorHUDanim.Play("HUDanimation");

		EstadojuegoNivelProgra.lives = EstadojuegoNivelProgra.lives - 1;


		audioFallSource.clip = audioFall;
		audioFallSource.Play();

		txtvidas.text = EstadojuegoNivelProgra.lives.ToString();
	 

		if (EstadojuegoNivelProgra.lives == 0) {

			lockCursor = !lockCursor;


			Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
			Cursor.visible = !lockCursor;

			source.clip = audiogameover;
			source.Play();
			Time.timeScale = 0.0f;  
			gameover.SetActive(true);

		

		}
	}

		

 


}
