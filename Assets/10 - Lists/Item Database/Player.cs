using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<ItemDB.Item> inventory = new List<ItemDB.Item>();
    public ItemDatabase itemDatabase;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //request item by ID
            itemDatabase.AddItem(0, this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            itemDatabase.RemoveItem(0, this);
        }
    }
}
