using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_DestroyTrigger : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D another)
    {
        transform.parent.gameObject.GetComponent<Floor>().DestroyObject();
    }
}
