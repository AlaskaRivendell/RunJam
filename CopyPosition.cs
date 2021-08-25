using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform TransTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = TransTarget.position;
    }
}
