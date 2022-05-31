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
        for(int i = 0; i < 5; i++)
            SpawnFloor(FloorList.Last().transform.Find("NextSpawnPoint").position);
    }

    private void SpawnFloor(Vector3 Position)
    {
        int index = new Random().Next(FloorTilesPrefab.Count);
        GameObject objectSpawned = Instantiate(FloorTilesPrefab[index], Position, Quaternion.identity); 
        FloorList.Add(objectSpawned);
        FloorCollider c = objectSpawned.transform.Find("DestroyObjectTrigger").GetComponent<FloorCollider>();
        c.spawnFloor = SpawnFloor;

    }
    
    private void SpawnFloor(FloorCollider c)
    {
        SpawnFloor(FloorList.Last().transform.Find("NextSpawnPoint").position);
        
        Debug.Log("before destroy " + c);
        Destroy(c.gameObject.gameObject.transform.parent.gameObject, 2f);
        Debug.Log("after destroy " + c);
    }
}
