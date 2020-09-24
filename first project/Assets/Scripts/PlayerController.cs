using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed = 60;
    private float speed = 20;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Moves the vehicle forward and back based on VerticalInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        // Moves the vehicle left and right based on horizontalInput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );
        
    }
}
