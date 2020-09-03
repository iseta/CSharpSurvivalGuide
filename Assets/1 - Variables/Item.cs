using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //name
    public string itemName;
    //description
    [TextArea]
    public string about;
    //icon
    public Sprite image;
    //attack
    public float strength;
    //price
    public int price;

    void Start()
    {
        Debug.Log("I am a " + itemName + " about me: " + about);
        Debug.Log("I deal " + strength + " damage and I cost " + price +" gold");
    }
}
