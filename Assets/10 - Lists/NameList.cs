using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameList : MonoBehaviour
{
    public List<string> namesList = new List<string>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var nameToBeRemoved = namesList[Random.Range(0, namesList.Count)];
            namesList.Remove(nameToBeRemoved);
            Debug.Log("This name was removed:" + nameToBeRemoved + ", the following names remain: ");
            PrintAllNames(namesList);
        }
    }

    public void PrintAllNames(List<string> namesList)
    {
        foreach(string s in namesList)
        {
            Debug.Log("Name is: " + s);
        }
    }
}
