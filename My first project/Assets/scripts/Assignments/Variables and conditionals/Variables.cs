using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int money; //whole number value
    public float change = 0.75f; //floating point numbers and decimals
    public bool isDay = true; //booleans are true or false
    public string loginName = "moster"; //alpha numeric text
    public int bread;

    // Start is called before the first frame update
    void Start()
    {
        money = 300;
        bread = 5;
        Debug.Log("Money in Account: $" + money);
        Debug.Log("Bread in Inventory: " + bread);
    }

    // Update is called once per frame
    void Update()
    {
        if(bread > 5)
        {
            Debug.Log("That's a lot of bread");
        }
        else if(bread < 5)
        {
            Debug.Log("Go get more bread");
        }


         if(money < 500)
        {
            Debug.Log("save that money");
        }
        else if(money > 500)
        {
            Debug.Log("You have money");
        }
        

         if(isDay == true)
        {
            Debug.Log("Daytime!!!!");
        }
        else
        {
            Debug.Log("Nighttime");
        } 
        

        if(loginName == "moster")
        {
            Debug.Log("Login Correct");
        }
        else
        {
            Debug.Log("Login incorrect");
        }
    }
}
