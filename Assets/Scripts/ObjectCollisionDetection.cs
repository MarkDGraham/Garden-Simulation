using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollisionDetection : MonoBehaviour
{
    public PlantLifeCycleEventSystem plant;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "TomatoSeed")
        {
            plant.seedCounter++;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "WaterDroplet")
        {
            plant.waterCounter++;
            Destroy(other.gameObject);
        }
    }
}
