using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerMovement")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    private float moveVelocity;
    private Vector2 direction;
    private SpriteRenderer _renderer;

    [Header("GroundCheck")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    [Header ("PlayerHealth")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;

    [Header ("Player Combat")]
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public int damage;
    public LayerMask enemyLayer;

    [Header("Inventory")]
    public int key;
    public int coins;

    [Header("Audio")]
    private AudioSource source; //audio
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        //sprite flip
         _renderer = GetComponent<SpriteRenderer>();
        //ground
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
        //health
        curHP = maxHP;
        healthBar.SetHealth(maxHP); //sends max HP into the health bar slider (set health)
        //audio
        source = GetComponent<AudioSource>();
    }

    void Update() //gets called once per frame
    {
        //flipping sprite to see direction
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            _renderer.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _renderer.flipX = true;
        }

        //ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); //checks if you're touching a layer??? idk

        //Non-stick player
        moveVelocity = 0f;

        //movement
        if(Input.GetKeyDown(KeyCode.W) && isGrounded) //up
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

        if(Input.GetKeyDown(KeyCode.K)) //attack (hopefully)
        {
            if(Time.time - lastAttackTime >=attackRate)
                Attack();
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight); //changing velocity on x, and maintaining velocity on y
        source.PlayOneShot(clip, 1.0f); //play a sound when jumping
    }

    void Attack()
    {
        lastAttackTime = Time.time;

        //RayCast using the enemy Layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;
        healthBar.SetHealth(curHP); //updates the heatlh bar using curHP

        if(curHP <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("You Died");
    }
}
