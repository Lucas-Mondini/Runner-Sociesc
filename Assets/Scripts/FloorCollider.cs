using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollider : MonoBehaviour
{
    public delegate void SpawnFloor(FloorCollider c);
    public SpawnFloor spawnFloor;
    private void OnTriggerEnter2D(Collider2D other)
    {
        try
        {
            spawnFloor(this);
        }
        catch (Exception e)
        { }
    }
}
