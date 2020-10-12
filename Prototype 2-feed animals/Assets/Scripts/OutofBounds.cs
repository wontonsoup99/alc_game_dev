using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public float topBounds = 31.0f;
    public float lowerBounds = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
        
    }
}
