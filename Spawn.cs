using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject goCreate;

    [SerializeField]
    float fTimeIntervals; //to set time intervals in which objects appear

    [SerializeField]
    Vector3 v3SpawnJitter; //for rendering

    float fTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
       fTimer = fTimeIntervals; 
    }

    // Update is called once per frame
    void Update()
    {
      fTimer -= Time.deltaTime;
      if (fTimer <= 0)
      {
          fTimer = fTimeIntervals;
          Vector3 v3SpawnPos = transform.position;
          v3SpawnPos += Vector3.right * v3SpawnJitter.x * (Random.value - 0.5f);
          v3SpawnPos += Vector3.forward * v3SpawnJitter.z * (Random.value - 0.5f);
          v3SpawnPos += Vector3.up * v3SpawnJitter.y * (Random.value - 0.5f);
          Instantiate(goCreate, v3SpawnPos, Quaternion.identity);
      }  
    }
}
