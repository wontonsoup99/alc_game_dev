using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //sets the offset for the camera based off the plane
    private Vector3 offset = new Vector3(30,0,10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //sets the camera to follow the planes position and adds an offset
        transform.position = plane.transform.position + offset;
    }
}
