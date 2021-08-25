using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControledVelocity : MonoBehaviour
{
    [SerializeField] //creates new to edit in inspector
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    // Update is called once per frame
    void FixedUpdate() //called excatly 100x per second - physics ideally here
    {
      if(Input.GetKey(keyPositive))
        GetComponent<Rigidbody>().velocity += v3Force;  //to communicate with object physics
      if(Input.GetKey(keyNegative))
        GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
