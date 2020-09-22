using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer[] customers;

    void Start()
    {
        customers[0] = new Customer("Brad", "Shaw", 34, 'M', "Programmer");
        customers[1] = new Customer("Molly", "Evans", 14, 'F', "Student");
        customers[2] = new Customer("Agnes", "DiPiero", 54, 'F', "Retired");
    }
}
