using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField] //creates new to edit in inspector
    Vector3 v3Force;

    // Update is called once per frame
    void FixedUpdate() //called excatly 100x per second - physics ideally here
    {
      GetComponent<Rigidbody>().velocity += v3Force;  //to communicate with object physics
    }
}
