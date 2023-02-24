using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }

    void SpawnPin ()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }

}
