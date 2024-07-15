using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //user access set to public to view/edit "speed" in Unity
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //Get Axis method is asking what axis to use in the form of a string
        horizontalInput = Input.GetAxis("Horizontal");
        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
