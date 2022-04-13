using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEwoks = 20;
    public int ducksInPond = 99;

    // Start is called before the first frame update
    void Start()
    {
        //0 is starting point. it'll loop until the parameters are false
        // i < numEwoks is the cap. it'll go to 20.
        // i++ takes i and adds 1. increments by 1. -- if you want to go down
        for(int i = 1; i <= numEwoks; i++) //for loops loop a set amount of times.
        {
            Debug.Log("There are " + i + " Ewoks are on a log.");
        }

        //this loop can repeat forever!! be careful!
        while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown south over the winter");
            ducksInPond --; //don't forget this!!
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
