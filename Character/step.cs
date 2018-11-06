using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step : MonoBehaviour {

    //public AudioSource som;
    
	// Use this for initialization
	void Start () {
		
	}


    //stepsAudio
    public CharacterController controller;
    public AudioClip[] concrete;
    private bool steps = true;
    float audioStepLengthWalk = 0.45f;
    float audioStepLengthRun = 0.25f;


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (controller.isGrounded && controller.velocity.magnitude < 7 && controller.velocity.magnitude > 5 && hit.gameObject.tag == "Untagged" && steps == true)
        {
            WalkOnConcrete();
        }

    }

    IEnumerator WaitForFootSteps(float stepsLength)
    {
        steps = false; yield return new WaitForSeconds(stepsLength); steps = true;
    } /////////////////////////////////// CONCRETE ////////////////////////////////////////

    void WalkOnConcrete()
    {
        AudioClip a = concrete[Random.Range(0, concrete.Length)];
        a.LoadAudioData();        
        //a.Play();
        //audio.Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));
    }


	// Update is called once per frame
	
}
