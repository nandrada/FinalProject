using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // calculating the distance between the player and the camera
        offset = transform.position - player.transform.position;
    }


    void Update()
    {
        // updating the camera to that position every frame
        transform.position = player.transform.position + offset;

    }

}
