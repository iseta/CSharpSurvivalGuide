using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public List<ItemD> itemList = new List<ItemD>();
    public Dictionary<int, ItemD> itemDictionary = new Dictionary<int, ItemD>();

    private void Start()
    {
        ItemD sword = new ItemD();
        sword.name = "Sword";
        sword.id = 0;

        itemList.Add(sword);
        itemDictionary.Add(0, sword);

        ItemD newItem = itemDictionary[0];
        Debug.Log(newItem.name);
    }
}
