using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropletLifeCycle : MonoBehaviour
{
    // Variables
    public float lifeTimer = 2f;

    // Update is called once per frame
    void Update()
    {
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0.0f)
        {
            Destroy(this.gameObject);
            lifeTimer = 2f;
        }
    }
}
