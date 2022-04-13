using UnityEngine;
using UnityEngine.UIElements;

public class CharacterController2D : MonoBehaviour
{
    public float AccelerationRight = 0.001f;
    public float VelocityRight = 0.0f;
    public float MaxVelocity = 1000f;
    void Start()
    {
        
    }
    
    void Update()
    {
        VelocityRight += AccelerationRight;
        if (VelocityRight > MaxVelocity)
            VelocityRight = MaxVelocity;
        transform.position += new Vector3((transform.position.x + AccelerationRight) * Time.deltaTime, 0, 0);
    }
}
