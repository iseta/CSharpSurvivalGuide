using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MainDelegate.onTeleport += TeleportCube;
    }

    public void TeleportCube(Vector3 pos)
    {
        gameObject.transform.position = pos;
    }

    private void OnDisable()
    {
        MainDelegate.onTeleport -= TeleportCube;
    }
}
