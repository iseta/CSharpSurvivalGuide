using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertCubes : MonoBehaviour
{
    public GameObject[] cubes;

    // The challenge was to turn cubes red using for loops, and not foreach loops, which would've been more efficient
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i<cubes.Length; i++)
            {
                cubes[i].GetComponent<Renderer>().material.color = Color.red;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }
}
