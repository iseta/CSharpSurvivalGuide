using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cube;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            ColorSwap(Color.red);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ColorSwap(Color.green);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ColorSwap(Color.yellow);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ColorSwap(Color.cyan);
        }
    }

    private void ColorSwap(Color colorToUse)
    {
        cube.GetComponent<Renderer>().material.color = colorToUse;
    }
}
