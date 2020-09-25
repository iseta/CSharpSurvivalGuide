using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTime : Employee
{
    public int salary;

    public override void CalculateMonthlySalary()
    {
        Debug.Log(employeeName + " works at " + companyName);
        Debug.Log("Full-Time / Monthly salary: " + salary);
    }
}

