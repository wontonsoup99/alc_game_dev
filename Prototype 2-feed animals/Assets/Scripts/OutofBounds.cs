using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public float lowerBound = 28.0f;
    public float topBound = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale =1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > lowerBound)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            Debug.Log("Game Over");


        }

        if(transform.position.z < topBound)
        {
            Destroy(gameObject);

        }
        
    }
}
