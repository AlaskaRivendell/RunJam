using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    string strSceneName;

    private void OnCollisionEnter(Collision collision) //only called on event
    {
        if (collision.collider.tag == strTag){
        SceneManager.LoadScene(strSceneName);
        }
    }
}