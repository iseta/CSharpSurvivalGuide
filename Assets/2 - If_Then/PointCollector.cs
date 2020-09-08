using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    public int pointsToAdd;
    public int totalPoints;
    private bool hasSaidMessage;

    void Update()
    {
        //Whenever the space key is pressed, add x points
        if (Input.GetKeyDown(KeyCode.Space))
        {
            totalPoints += pointsToAdd;
            if (totalPoints >= 50 && !hasSaidMessage)
            {
                hasSaidMessage = true;
                Debug.Log("You're awesome!");
            }
        }
    }
}
