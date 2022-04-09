using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [Header ("Player Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;

    [Header ("Player Movement")]
    public float moveSpeed = 5f; //player speed
    private Rigidbody2D rb; //the 2d's rigidbody ref
    private Vector2 movement; //x and y position storage for movement
    private Vector2 direction;

    [Header ("Player Combat")]
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public int damage;
    public LayerMask enemyLayer;

    [Header("Inventory")]
    public int key;
    public int coins;
    public int gems;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        curHP = maxHP;
        healthBar.SetHealth(maxHP); //sends max HP into the health bar slider (set health)
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //left right move
        movement.y = Input.GetAxis("Vertical"); //up down move

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastAttackTime >=attackRate)
                Attack();
        }
    }

//set number of calls per frame. best for physics
    void FixedUpdate() 
    {
        //apply physics and move character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y); //vel is short for velocity

        if(vel.magnitude != 0)
        {
            direction = vel;
        }

        rb.velocity = vel * moveSpeed; //makes the unity velocity equal vel
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
