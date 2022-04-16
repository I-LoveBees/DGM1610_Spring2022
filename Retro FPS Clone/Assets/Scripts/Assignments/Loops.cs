using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEwoks = 20;
    public int numCats = 30;
    public int blankets = 7;
    public int phones = 3;
    public int halos = 6;

    public int ducksInPond = 10;
    public int n = 0;
    public int m = 5;
    public int p = 3;
    public int q = 6;

    // Start is called before the first frame update
    void Start()
    {
        /*
        0 is starting point. it'll loop until the parameters are false
        i < numEwoks is the cap. it'll go to 20.
         i++ takes i and adds 1. increments by 1. -- if you want to go down
        
        
        for (statement 1; statement 2; statement 3) 
        {
         // code block to be executed
        }

        Statement 1 is executed (one time) before the execution of the code block.

        Statement 2 defines the condition for executing the code block.

        Statement 3 is executed (every time) after the code block has been executed.

        */
        for(int i = 1; i <= numEwoks; i++) //for loops loop a set amount of times.
        {
            Debug.Log("There are " + i + " Ewoks are on a log.");
        }

        for(int a = 1; a <= numCats; a++)
        {
            Debug.Log("There are "+ a + " Cats on my lap.");
        }

        for(int e = 1; e <= blankets; e++)
        {
            Debug.Log("There are "+ e + " Blankets folded.");
        }

        for(int o = 1; o <= phones; o++)
        {
            Debug.Log("There are "+ o + " phones on the table.");
        }

        for(int u = 1; u <= halos; u++)
        {
            Debug.Log("There are "+ u + " Halo games out.");
        }


        /*
        The while loop loops through a block of code as long as a specified condition is True
        
        while (condition) 
        {
          code block to be executed
        }
        */

        //this loop can repeat forever!! be careful!
        while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown south over the winter");
            ducksInPond --; //don't forget this!!
        }

        while(n < 5)
        {
            Debug.Log(n);
            Debug.Log("n = " + n);
            n ++;
        }

        while(m > 0)
        {
            Debug.Log(m);
            Debug.Log("m = " + m);
            m --;
        }

        while(p > 0)
        {
            Debug.Log(p);
            Debug.Log("p = " + p);
            p --;
        }

        while(q > 0)
        {
            Debug.Log(q);
            Debug.Log("q = " + q);
            q --;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
