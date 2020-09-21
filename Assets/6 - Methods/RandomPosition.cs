using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public GameObject cube;
    public Vector3[] positions;

    // Start is called before the first frame update
    void Start()
    {
        cube.transform.position = RandomizePos();
    }

    private Vector3 RandomizePos()
    {
        return new Vector3(positions[Random.Range(0, positions.Length - 1)].x, positions[Random.Range(0, positions.Length - 1)].y, positions[Random.Range(0, positions.Length - 1)].z);
    }
}
