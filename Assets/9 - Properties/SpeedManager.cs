using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    private int _speed;

    public int speed
    {
        get
        {
            Debug.Log("My speed is: ");
            return _speed;
        }
    }

    private string objectName { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
