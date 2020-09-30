using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellor : MonoBehaviour
{
    // sets the speed at which the propellor rotates
    public float propellorSpeed = 1000;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Makes propellor spin constantly when the game is started
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
