using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    public int layer = -100;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (PlayerTransform)
            transform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y, layer);
    }
}
