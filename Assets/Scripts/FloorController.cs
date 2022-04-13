using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    public GameObject firstFloor;
    public GameObject floor;
    List<Floor> floors = new List<Floor>();
    void Start()
    {
        firstFloor.GetComponent<Floor>().controller = this;
        floors.Add(firstFloor.GetComponent<Floor>());
        addFloorTile();
        addFloorTile();
    }

    public void floorDestroyed(Floor caller)
    {
        floors.Remove(caller);
    }
    
    public void addFloorTile()
    {
        Floor f = floors.Last();
        Transform t = f.getNextSpawnPoint();
        floors.Add(Instantiate(floor.gameObject, t.position, t.rotation).GetComponent<Floor>());
        floors.Last().controller = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
