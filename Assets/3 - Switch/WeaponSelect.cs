using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public int _weaponID;

    // Update is called once per frame
    void Update()
    {
        switch (_weaponID)
        {
            case 0:
                Debug.Log("Gun");
                break;
            case 1:
                Debug.Log("Knife");
                break;
            case 2:
                Debug.Log("Machine Gun");
                break;
            default:
                Debug.Log("Invalid selection");
                break;
        }
    }
}
