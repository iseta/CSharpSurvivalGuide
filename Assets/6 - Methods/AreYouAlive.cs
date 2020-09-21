using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{
    public int health;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health = DoDamage(Random.Range(1, 10));
        }
    }

    public int DoDamage(int damage)
    {
        int aux = health - damage;
        if (aux <= 0)
        {
            Debug.Log("The player has died!");
            health = 0;
            Destroy(this);
        }
        return health - damage;
    }
}
