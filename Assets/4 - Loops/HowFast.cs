using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowFast : MonoBehaviour
{
    public int maxSpeed;
    [SerializeField]
    private int _currentSpeed;

    void Start()
    {
        StartCoroutine(incrementSpeed());
    }

    IEnumerator incrementSpeed()
    {
        while(_currentSpeed < maxSpeed)
        {
            _currentSpeed += 5;
            yield return new WaitForSeconds(5);
        }
    }

}
