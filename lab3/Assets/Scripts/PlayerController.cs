using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float speed = 10.0f;
    public int bounds = 2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xPos = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * xPos * Time.deltaTime * speed);

        yPos = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * yPos * Time.deltaTime * speed);

        if(transform.position.x < -bounds)
        {
            transform.position = new Vector3(-bounds, transform.position.y, transform.position.z);
        }

        if (transform.position.x > bounds)
        {
            transform.position = new Vector3(bounds, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -bounds)
        {
            transform.position = new Vector3(transform.position.x, -bounds, transform.position.z);
        }
        if (transform.position.y > bounds)
        {
            transform.position = new Vector3(transform.position.x, bounds, transform.position.z);
        }


    }
}
