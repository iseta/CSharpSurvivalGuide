using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //bill amount
    public float billAmount;

    //tip percentage
    public float tipPercentage;

    //total amount = bill+tip
    float totalAmount;

    void Start()
    {
        totalAmount = billAmount + ((tipPercentage / 100) * billAmount);
        Debug.Log("Your bill is: " + billAmount + ", and the total amount, with a " + tipPercentage + "% tip is: " + totalAmount);
    }

}
