using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //function Rotate will rotate the object according with the Unity time in seconds
        //the rotations happens on all 3 axes
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
