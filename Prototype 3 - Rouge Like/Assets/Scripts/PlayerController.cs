using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; //player speed
    private Rigidbody2D rb; //the 2d's rigidbody ref

    Vector2 movement; //x and y position storage for movement

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //left right move
        movement.y = Input.GetAxis("Vertical"); //up down move
    }

//set number of calls per frame. best for physics
    void FixedUpdate() 
    {
        //apply physics and move character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}