using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //store the position of the player as a parameter from Unity
    public GameObject player;
    //is private because we set te value in the script
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //store the position of the camera - the position of the player
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //the position of the camera is changed as the player is moving
        transform.position = player.transform.position + offset;
    }
}
