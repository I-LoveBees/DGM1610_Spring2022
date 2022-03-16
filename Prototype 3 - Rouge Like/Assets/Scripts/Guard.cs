using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
    public float speed;
    public float startWaitTime;
    public Transform startPoint;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private float waitTime;

    
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        startPoint.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, startPoint.position, speed * Time.deltaTime);

       if(Vector2.Distance(transform.position, startPoint.position) < 0.2f)
       {
           if(waitTime <= 0)
           {
               startPoint.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)); //setting a new waypoint
               waitTime = startWaitTime; //resets wait time
           }
           else
           {
               waitTime -= Time.deltaTime;
           }
       } 
    }
}
