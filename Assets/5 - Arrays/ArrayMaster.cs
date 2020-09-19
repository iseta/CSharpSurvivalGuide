using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMaster : MonoBehaviour
{
    //Array with kids names
    public string[] names;

    //Array with their ages
    public int[] ages;

    //Array with their favorite cars
    public string[] favoriteCars;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if(names!=null && favoriteCars != null)
            {
                Debug.Log(names[names.Length -1] + " is "+ages[ages.Length -1]+" year(s) old and their favorite car is: " + favoriteCars[favoriteCars.Length -1]);
            }
        }
    }
}
