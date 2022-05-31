using UnityEngine;
using UnityEngine.UIElements;

public class CharacterController2D : MonoBehaviour
{
    public float AccelerationRight = 0.001f;
    public float InitialVelocity = 10.0f;
    public float VelocityRight = 0.0f;
    public float MaxVelocity = 1000f;
    public float jumpHeigt = 5;
    public Rigidbody2D RD;
    public bool isGrounded = true;

    void Start()
    {
        RD = GetComponent<Rigidbody2D>();
        RD.velocity = new Vector2(InitialVelocity, 0);
        transform.Find("FloorTrigger").GetComponent<CharacterFloorTrigger>().characterScriptRef = this;
    }
    
    void Update()
    {

        transform.Translate(5f * Time.deltaTime, 0f, 0f);
        //var onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            RD.velocity = new Vector2(RD.velocity.x, jumpHeigt);
            isGrounded = false;
        }
    }

    void Grounded()
    {
        isGrounded = true;
    }
}
