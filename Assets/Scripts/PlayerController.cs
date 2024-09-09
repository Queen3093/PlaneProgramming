using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 5f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float forwardInput;


    // Update is called once per frame
    void Update()
    {
        //Input vairiables to use the keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward based on forward input
	    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotate the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
