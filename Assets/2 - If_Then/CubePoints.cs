using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePoints : MonoBehaviour
{
    //Gameobject 
    public GameObject cube;

    //Score value
    private int _score;

    //Was color changed
    private bool _wasColorChanged;

    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
            if (_score > 50 && !_wasColorChanged)
            {
                cube.GetComponent<Renderer>().material.color = Color.green;
                _wasColorChanged = true;
            }
        }
    }
}
