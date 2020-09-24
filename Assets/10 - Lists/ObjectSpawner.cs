using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> objectsToSpawn = new List<GameObject>();
    public List<GameObject> objectsSpawned = new List<GameObject>();

    private bool disableSpawn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !disableSpawn)
        {
            SpawnObjectAtRandomPos(objectsToSpawn[Random.Range(0, objectsToSpawn.Count)]);
        }
    }

    void SpawnObjectAtRandomPos(GameObject obj)
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0);
        GameObject objInstance = Instantiate(obj, gameObject.transform);
        objInstance.transform.position = randomPosition;
        objectsSpawned.Add(objInstance);
        if (objectsSpawned.Count == 10)
        {
            disableSpawn = true;
            TurnObjectsGreen();
        }
    }

    void TurnObjectsGreen()
    {
        foreach(GameObject obj in objectsSpawned)
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
        objectsSpawned.Clear();
    }
}
