using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstpersoncontroller : MonoBehaviour {

    



    public float movementSpeed = 5.0f;
    public float mouseSensetivity = 5.0f;

    float verticalRotation = 0;
    public float UpDownRange = 60.0f;


	// Use this for initialization
	void Start ()
    {
      //  Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        

        //Rotation 

        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensetivity;
        transform.Rotate(0, rotLeftRight, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensetivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -UpDownRange, UpDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        //Movement
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);

        speed = transform.rotation * speed;

        CharacterController control = GetComponent<CharacterController>();

        control.Move( speed * Time.deltaTime );

	}
}
