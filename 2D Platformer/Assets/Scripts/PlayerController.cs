using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    [Header("GroundCheck")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private float moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() //gets called once per set number of times??
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); //checks if you're touching a layer??? idk

        //Non-stick player
        moveVelocity = 0f;

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) //up
        {
            Jump();
        }

        if(Input.GetKey(KeyCode.D)) //right
        {
            moveVelocity = speed;
        }
        
        if(Input.GetKey(KeyCode.A)) //left
        {
            moveVelocity = -speed;
        }
        
        //moving player left and right 
        rb.velocity = new Vector2(moveVelocity,rb.velocity.y);
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight); //changing velocity on x, and maintaining velocity on y
    }
}
