using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public float topBounds = -10.0f;
    public float lowerBounds = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
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
            //Debug.Log("Game Over");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
        
    }
}
