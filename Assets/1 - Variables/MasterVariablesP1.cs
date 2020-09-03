using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVariablesP1 : MonoBehaviour
{
    //create a variable to store your name
    public string myName;

    //create a variable to store your age
    public int myAge;

    //create a health variable
    public int health;

    //create a score variable
    public int score;

    //create a variable for ammo count
    public int ammoCount;

    //create a variable to store your speed
    public float speed;

    //create a variable to check if all keys were collected
    public bool allKeysColected;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is: " + myName + ", my age is: " + myAge + " and I am: "+ speed +" units fast");
        Debug.Log("My current health is: " + health + ", my score is: " + score +" and I have: "+ammoCount+" of ammo");
        Debug.Log("Do I have all my keys? " + allKeysColected);
    }

}
