using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 18;

    public float turnSpeed = 60;

    private Rigidbody rig;

	// Use this for initialization
	void Start ()
    {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {

		float dPadX = Input.GetAxis("XBOX360_DPadX");

		float dPadY = Input.GetAxis("XBOX360_DPadY");

        float triggerAxis = Input.GetAxis("XBOX360_Triggers");

        if (dPadX != 0)
        {
            print("DPad Horizontal Value: " + dPadX);
        }
        if (dPadY != 0)
        {
            print("DPad Vertical Value: " + dPadY);
        }
        if (triggerAxis != 0)
        {
            print("Trigger Value: " + triggerAxis);
        }
		if (Input.GetButtonDown("XBOX360_LBumper"))
        {
            print("Left Bumper");
        }
		if (Input.GetButtonDown("XBOX360_RBumper"))
        {
            print("Right Bumper");
        }
		if (Input.GetButtonDown("XBOX360_A"))
        {
            print("A Button");
        }
		if (Input.GetButtonDown("XBOX360_B"))
        {
            print("B Button");
        }
		if (Input.GetButtonDown("XBOX360_X"))
        {
            print("X Button");
        }
		if (Input.GetButtonDown("XBOX360_Y"))
        {
            print("Y Button");
        }
		if (Input.GetButtonDown("XBOX360_Back"))
        {
            print("Back Button");
        }
		if (Input.GetButtonDown("XBOX360_Start"))
        {
            print("Start Button");
        }
		if (Input.GetButtonDown("XBOX360_LStickClick"))
        {
            print("Clicked Left Stick");
        }
		if (Input.GetButtonDown("XBOX360_RStickClick"))
        {
            print("Clicked Right Stick");
        }

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

		float rStickX = Input.GetAxis("XBOX360_RStickX");

        Vector3 movement = transform.TransformDirection(new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime);

        rig.MovePosition(transform.position + movement);

        Quaternion rotation = Quaternion.Euler(new Vector3(0, rStickX, 0) * turnSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, rStickX, 0), turnSpeed * Time.deltaTime);
	}
}
