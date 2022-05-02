using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    // Variables
    public GameObject waterDropletPrefab;
    public float spawnTimer = 0.1f;
    public float upperTiltBound = 295.0f;
    public float lowerTiltBound = 335.0f;

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0 &&
            transform.parent.eulerAngles.x <= upperTiltBound &&
            transform.parent.eulerAngles.x >= lowerTiltBound)
        {
            Instantiate(waterDropletPrefab, transform.position, transform.rotation);
            spawnTimer = 0.1f;
        }

        Debug.Log(transform.parent.rotation.eulerAngles.x);
    }
}
