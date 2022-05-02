using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSpawner : MonoBehaviour
{
    // Variables
    public GameObject seedPrefab;
    public float spawnTimer = 0.1f;
    public float upperTiltBound = 110.0f;
    public float lowerTiltBound = 70.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0 &&
            transform.parent.rotation.eulerAngles.z >= lowerTiltBound &&
            transform.parent.rotation.eulerAngles.z <= upperTiltBound)
        {
            Instantiate(seedPrefab, transform.position, transform.rotation);
            spawnTimer = 0.1f;
        }

        Debug.Log((transform.parent.rotation.eulerAngles.z <= upperTiltBound) + "  " + (transform.parent.rotation.eulerAngles.z <= lowerTiltBound));
    }
}
