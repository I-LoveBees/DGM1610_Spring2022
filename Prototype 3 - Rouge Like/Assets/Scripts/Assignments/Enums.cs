using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {red, orange, yellow, green, blue, purple} //enums can be run outside of the main class
    enum CarMake {OldsMobile, Chevrolet, Ford, Mazda, Dodge, Toyota}
    enum CarModel { Alero, Cruze, Tacoma, Mustang, Miata, Viper}
    enum Shapes {square, rectangle, circle, cylinder, triangle}
    enum Flower {rose, daffodil, chamomile, tulip, dandilion}
    enum MusicGenre {metal, rock, indie, pop, punk, electronic, rap}
    enum Animal {monkey, cat, dog, bee}
    enum Sports {dance, football, soccer, cheerleading, swim}
    enum Weapon {gun, knife, sword, taser, bat, nuke}
    enum Flavors {vanilla, chocolate, strawberry, hazelnut}

    // Start is called before the first frame update
    void Start()
    {
        Color paint; //paint of type: color
        paint = Color.orange;
        print(paint); //paint should say orange

        CarMake make;
        CarModel model;
        make = CarMake.Chevrolet;
        model = CarModel.Tacoma;
        print("Car Manufacture: " + make + "Model: " + model);

        Shapes shape;
        shape = Shapes.circle;
        print(shape);

        Flower flower;
        flower = Flower.daffodil;
        print(flower);

        MusicGenre genre;
        genre = MusicGenre.punk;
        print(genre);

        Animal pet;
        pet = Animal.bee;
        print("Your new pet is a " + pet);

        Sports sport;
        sport = Sports.swim;
        print(sport);

        Weapon weapon;
        weapon = Weapon.taser;
        print("You were killed by a " + weapon);

        Flavors flavor;
        flavor = Flavors.strawberry;
        print("Welcome to " + flavor + "town!");

        //Recall(CarMake.Mazda, CarModel.Miata);
    }

    /*void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.OldsMobile && model == CarModel.Alero)
        {
            print("There's a recall on your vehicle. Get rid of it.");
        }
        else if(make == CarMake.Ford && CarModel.Mustang)
        {
            print("There's a recall on your vehicle. Get them to the dump.");
        }
        else
        {
            print("There's nothing wrong I promise");
        }
    }
    */
}
