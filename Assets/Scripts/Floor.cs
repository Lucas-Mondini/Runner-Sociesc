using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Floor : MonoBehaviour
{
    public FloorController controller;

    // Start is called before the first frame update
    void Start()
    {
        transform.Find("DestroyObjectTrigger");

    }

    public Transform getNextSpawnPoint()
    {
        Transform t = GameObject.Find("NextSpawnPoint").transform;
        t.position += gameObject.transform.position;
        t.position = new Vector3(t.transform.position.x, t.transform.position.y, -2f);
        return t;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void addNextChunk()
    {
        controller.addFloorTile();
    }

    public void DestroyObject()
    {
        controller.floorDestroyed(this);
        Destroy(gameObject);
    }
}
