using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemDB;

public class ItemDatabase : MonoBehaviour
{
    public List<ItemDB.Item> itemDatabase = new List<ItemDB.Item>();
    
    public void AddItem(int ItemID, Player player)
    {
        //check if item matches something
        foreach(ItemDB.Item it in itemDatabase)
        {
            if(it.id == ItemID)
            {
                Debug.Log("We have a match!");
                player.inventory.Add(it);
                return;
            }
        }
        Debug.Log("Item does not exist!");
    }

    public void RemoveItem(int ItemID, Player player)
    {
        //check if item matches something
        foreach (ItemDB.Item it in itemDatabase)
        {
            if (it.id == ItemID)
            {
                Debug.Log("We have a match!");
                player.inventory.Remove(it);
                return;
            }
        }
        Debug.Log("Item does not exist!");
    }
}
