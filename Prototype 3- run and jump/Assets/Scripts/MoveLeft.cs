using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
         {
            Destroy(gameObject);
        }
         if (playerControllerScript.gameOver == false)
        {
            //Moves the GameObject left at a set speed
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
