using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemENUM
{
    public string name;
    public int ID;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable
    }

    public ItemType itemType;

    public void Action()
    {
        switch (itemType)
        {
            case ItemType.Weapon:
                Debug.Log("This is a weapon!");
                break;
            case ItemType.Consumable:
                Debug.Log("This is a consumable!");
                break;
        }
    }
}
