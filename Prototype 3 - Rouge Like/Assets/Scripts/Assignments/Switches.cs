using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public string energyDrink;
    public string colors;
    public string shapeChair;
    public string swimStrokes;
    public int socialClass;
    public int aquaticAnimals;
    public int giveGift;
    public int petOptions;
    public int timeOfDay;

    // Start is called before the first frame update
    void Start()
    {
        switch(npcConv)
        {
            case "Hello":
            print("Hello good citizen!");
            break;
            case "Goodbye":
            print("Goodbye! Safe travels!");
            break;
            case "We are being attacked":
            print("You run away in shame, you coward");
            break;
        }

        switch(energyDrink)
        {
            case "Monster":
            print("This has 140mg of caffeine!");
            break;
            case "Redbull":
            print("This has 80mg of caffeine!");
            break;
            case "Bang":
            print("This has 300mg of caffeine!");
            break;
        }

        switch(colors)
        {
            case "red":
            print("Your hair is now red.");
            break;
            case "orange":
            print("Your hair is now orange.");
            break;
            case "yellow":
            print("Your hair is now orange.");
            break;
            case "green":
            print("Your hair is now green");
            break;
            case "blue":
            print("Your hair is now blue");
            break;
            case "purple":
            print("Your hair is now purple");
            break;
        }
        switch(shapeChair)
        {
            case "square":
            print("What a nice chair.");
            break;
            case "rectangle":
            print("That's a long chair.");
            break;
            case "triangle":
            print("What a strange triangular chair.");
            break;
        }

        switch(swimStrokes)
        {
            case "freestyle":
            print("The easiest stroke to learn. Has many names.");
            break;
            case "backstroke":
            print("The second easiest stroke. Requires being able to float on your back");
            break;
            case "breaststroke":
            print("Also known as frog stroke. The personal favorite stroke of the coder's ;) .");
            break;
            case "butterfly":
            print("The hardest stroke. Requires great upper body strength, endurance, and rhythm");
            break;
        }

        switch(socialClass)
        {
            case 5:
            Debug.Log("Hello, your Magesty");
            break;
            case 4:
            Debug.Log("Hello young Princess!");
            break;
            case 3:
            Debug.Log("Good evening Duke");
            break;
            case 2:
            Debug.Log("Hello Governor");
            break;
            case 1:
            Debug.Log("Hello");
            break;
            case 0:
            Debug.Log("Who are you?");
            break;
            default:
            Debug.Log("...");
            break;
        }

        switch(aquaticAnimals)
        {
            case 3:
            print("I love Octopus");
            break;
            case 2:
            print("I love Shrimp");
            break;
            case 1:
            print("I love Fish");
            break;
            case 0:
            print("I love Starfish");
            break;
        }

        switch(giveGift)
        {
            case 3:
            print("Thanks for the gift! This is what I've always wanted!");
            break;
            case 2:
            print("Thanks for the gift!");
            break;
            case 1:
            print("Oh... Thanks.");
            break;
            case 0:
            print("... What is this?");
            break;
        }

        switch(petOptions)
        {
            case 3:
            print("Cat. $30");
            break;
            case 2:
            print("Dog. $50");
            break;
            case 1:
            print("Fish. $10 each");
            break;
            case 0:
            print("Bird. $15 each");
            break;
        }

        switch(timeOfDay)
        {
            case 3:
            print("It is morning");
            break;
            case 2:
            print("It is day");
            break;
            case 1:
            print("It is evening");
            break;
            case 0:
            print("It is night. You better run.");
            break;
        }
    }
}
