using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    public float distance; //distance from ground?
    private bool moveRight = true; //initial direction

    [Header("Detection")]
    public Transform groundDetect;
    public Transform wallDetect;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //initial movement

        //type       name                            detecting the ground with Vector2.down by casting the Ray down
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetect.position, Vector2.down, distance); 
        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetect.position, Vector2.left, distance); //trying to add wall detection

        if(groundInfo.collider == false || wallInfo.collider == true) // or if it detects a wall
        {
            if(moveRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0); //flip at edge to turn left. eulerAngles is more effective with Vector3 instead of Vector2 (?)
                moveRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0,0,0); //flip on edge to move right
                moveRight = true;
            }
        }
    }
}
