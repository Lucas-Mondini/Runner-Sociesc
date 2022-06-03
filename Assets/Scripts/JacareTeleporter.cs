using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class JacareTeleporter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Jacare;
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x > Jacare.transform.position.x + 50)
        {
            Vector3 p = Jacare.transform.position;
            p.x = Player.transform.position.x - 45;
            Jacare.transform.position = p;
        }
    }
}
