using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumDatabase : MonoBehaviour
{
    public List<ItemENUM> itemList = new List<ItemENUM>();

    private void Start()
    {
        itemList[0].Action();
    }
}
