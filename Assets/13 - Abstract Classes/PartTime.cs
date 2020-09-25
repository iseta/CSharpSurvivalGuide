using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTime : Employee
{
    public int hoursWorked;
    public int hourlyRate;

    public override void CalculateMonthlySalary()
    {
        Debug.Log(employeeName + " works at " + companyName);
        Debug.Log("Part-Time / Monthly salary: " + hourlyRate * hoursWorked);
    }

}
