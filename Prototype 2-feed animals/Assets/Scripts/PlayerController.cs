﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public int xRange = 20;
    public GameObject ProjectileFood;
   

    // Update is called once per frame
    void Update()
    {   //allows control of player using arrow keys and space bar
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))

            //launch a projectile from the player
            Instantiate(ProjectileFood,transform.position,ProjectileFood.transform.rotation);
    }
}
