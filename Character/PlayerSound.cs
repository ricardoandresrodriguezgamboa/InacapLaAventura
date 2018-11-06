using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour {

    public AudioClip pisadita;
    public AudioSource audioS;


	/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/

    void Pisar()
    {
        //audioS.Play();

        
        audioS.PlayOneShot(pisadita);
    }
}
