using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    public string firstName;
    public string lastName;
    public int age;
    public char gender;
    public string occupation;

    public Customer(string firstName, string lastName, int age, char gender, string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }
}
