using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayRandomlySelect : MonoBehaviour
{
    //Array with kids names
    public string[] names;

    //Array with their ages
    public int[] ages;

    //Array with their favorite cars
    public string[] favoriteCars;

    private int _randomIndex;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (names != null && favoriteCars != null)
            {
                _randomIndex = Random.Range(0, names.Length - 1);
                Debug.Log(names[_randomIndex] + " is " + ages[_randomIndex] + " year(s) old and their favorite car is: " + favoriteCars[_randomIndex]);
            }
        }
    }
}
