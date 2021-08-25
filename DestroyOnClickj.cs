using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClickj : MonoBehaviour
{
  private void OnMouseDown() {
        Destroy(this.gameObject);    
    }
}
