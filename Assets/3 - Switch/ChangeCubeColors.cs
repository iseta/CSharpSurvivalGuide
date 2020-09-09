using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColors : MonoBehaviour
{
    public GameObject cube;

    private Renderer _cubeRenderer;
    private int _colorVariable = 0;

    private void Start()
    {
        //In the original code of the series, the instructor gets the renderer everytime a key is pressed
        _cubeRenderer = cube.GetComponent<Renderer>();
    }

    void Update()
    {
        //I kinda think that the color could be changed directly, but for the intent of the course I'm just doing it like that
        if (Input.GetKeyDown(KeyCode.W))
        {
            _colorVariable = 0;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _colorVariable = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _colorVariable = 2;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _colorVariable = 3;
        }

        switch (_colorVariable)
        {
            case 0:
                _cubeRenderer.material.color = Color.blue;
                break;
            case 1:
                _cubeRenderer.material.color = Color.red;
                break;
            case 2:
                _cubeRenderer.material.color = Color.green;
                break;
            case 3:
                _cubeRenderer.material.color = Color.black;
                break;
        }
    }
}
