using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerMovement")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    private float moveVelocity;
    private Vector2 direction;

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
    public GameObject bullet;


    [Header("Inventory")]
    public int key;
    public int coins;

    [Header("Audio")]
    private AudioSource source; //audio
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
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

        if(Input.GetKey(KeyCode.Space)) //attack (hopefully)
        {
            
            if(Time.time - lastAttackTime >=attackRate)
            {
                Attack();

            }
           
            
           // Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight); //changing velocity on x, and maintaining velocity on y
     
    }

    public void Attack()
    {

        lastAttackTime = Time.time;

        //RayCast using the enemy Layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        // not working
        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
            Debug.Log("I am attacking");
            //maybe i can shoot with this
            Instantiate(bullet, transform.position, Quaternion.identity);

        }
        


    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;
        healthBar.SetHealth(curHP); //updates the heatlh bar using curHP

        source.PlayOneShot(clip, 1.0f); //play a sound when getting hit

        if(curHP <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("You Died");
        SceneManager.LoadScene(3); //should go to the death screen
    }
}
