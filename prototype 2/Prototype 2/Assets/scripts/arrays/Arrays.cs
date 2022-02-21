using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Bob", "Jessica", "Harley", "Jody"};
    //                           { 0,     1,       2,       3}

    public int[] numbers = {23, 45,56,67,78,89};

    public string[] gems = {"Diamond", "Quartz", "Ruby", "Lapis Lazuli"};
    public int[] oddNumbers = {1,3,5,7,9,11,13,15,17,19,21};
    public int [] evenNumbers = {2,4,6,8,10,12,14,16,18,20};
    public string[] colors = {"red", "orange", "yellow", "green", "blue", "purple", "gray", "black", "white"};
    public int[] goodSleep = {7,8,9,10};
    public int[] badSleep = {1,2,3,4,5,6,11,12,13,14,15,16,17,18,19,20,21,22,23,24};
    public string[] jewelry = {"bracelet", "necklace", "ring", "earring",};
    public string[] catTypes = {"goblin", "normal", "fluffy"};

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend " + friendNames[0]);
        Debug.Log(friendNames[0]);
        friendNames[0] = "Veronica";
        Debug.Log("New friend " + friendNames[0]);
        */

        Debug.Log(gems[0]);
        Debug.Log(colors[4]);
        Debug.Log(jewelry[3]);
        Debug.Log(catTypes[0]);

        foreach(int numbers in numbers)
        {

         print(numbers);

        }


        foreach(int oddNumbers in oddNumbers)
        {

         print(oddNumbers);

        }

        foreach(int evenNumbers in evenNumbers)
        {

         print(evenNumbers);

        }

        foreach(int goodSleep in goodSleep)
        {

         print(goodSleep);

        }

        foreach(int badSleep in badSleep)
        {

         print(badSleep);

        }
    }
}
