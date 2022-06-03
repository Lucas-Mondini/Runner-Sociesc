using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

public class LevelGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject FloorRef;
    [SerializeField] private List<GameObject> FloorList = new List<GameObject>();
    public List<GameObject> FloorTilesPrefab;
    private void Awake()
    {
        FloorList.Add(FloorRef);
        for (int i = 0; i < 5; i++)
        {
            Vector3 pos = FloorList.Last().transform.Find("FloorSample").transform.Find("FloorSample").transform.Find("NextSpawnPoint").position;
            SpawnFloor(pos);
        }
    }

    private void SpawnFloor(Vector3 Position)
    {
        int total = FloorTilesPrefab.Count;
        int index = new Random().Next(total);
        Position.z = 0;

        Debug.Log("total = " + total + "\tindex = " + index);
        GameObject objectSpawned = Instantiate(FloorTilesPrefab[index], Position, Quaternion.identity); 
        FloorList.Add(objectSpawned);
        FloorCollider c;
        c = objectSpawned.transform.Find("FloorSample").transform.Find("FloorSample").transform.Find("DestroyObjectTrigger")
                .GetComponent<FloorCollider>();
        

        c.spawnFloor = SpawnFloor;

    }
    
    private void SpawnFloor(FloorCollider c)
    {
        SpawnFloor(FloorList.Last().transform.Find("FloorSample").transform.Find("FloorSample").transform.Find("NextSpawnPoint").position);
        
        Destroy(c.gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject, 5f);
    }
}
