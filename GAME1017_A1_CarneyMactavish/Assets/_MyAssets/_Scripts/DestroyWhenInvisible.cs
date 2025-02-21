using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenInvisible : MonoBehaviour
{
  void OnBecameInvisible()
    {
        Destroy(transform.parent.gameObject);
    }
}
