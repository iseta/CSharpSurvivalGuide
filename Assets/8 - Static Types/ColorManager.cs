using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;
    public GameObject capsule;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ColorHelper.ChangeColor(sphere, Color.white, true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ColorHelper.ChangeColor(cube, Color.white, true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ColorHelper.ChangeColor(cylinder, Color.white, true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ColorHelper.ChangeColor(capsule, Color.white, true);
        }
    }
}
