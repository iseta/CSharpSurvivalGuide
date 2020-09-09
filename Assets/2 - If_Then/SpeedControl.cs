using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{
    //Speed variable
    private int _speed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _speed += 10;
            if (_speed > 20)
            {
                Debug.Log("Slow down!");
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (_speed > 0)
            {
                _speed -= 10;
            } else if (_speed == 0)
            {
                Debug.Log("Speed up!");
            }
        }
    }
}
