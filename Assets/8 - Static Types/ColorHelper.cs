using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorHelper
{
    public static void ChangeColor(GameObject g, Color color, bool isRandomized){
        if (isRandomized)
        {
            color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        g.GetComponent<Renderer>().material.color = color;
    }
}
