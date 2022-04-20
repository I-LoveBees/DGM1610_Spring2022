using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public float distance; //distance from ground?
    private bool moveRight = true; //initial direction
    public Transform groundDetect;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //initial movement

        //type       name                            detecting the ground with Vector2.down by casting the Ray down
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetect.position, Vector2.down, distance); 

        if(groundInfo.collider == false)
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
