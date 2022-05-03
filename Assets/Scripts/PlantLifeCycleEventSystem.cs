using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlantLifeCycleEventSystem : MonoBehaviour
{
    public TextMeshProUGUI plantString;
    public GameObject unseededDirt;
    public GameObject tomatoDirtStage1;
    public GameObject tomatoDirtStage2;
    public GameObject tomatoDirtStage3;
    public GameObject tomatoDirtFinalStage;
    public int waterCounter = 0;
    public int seedCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        unseededDirt.SetActive(true);
        tomatoDirtStage1.SetActive(false);
        tomatoDirtStage2.SetActive(false);
        tomatoDirtStage3.SetActive(false);        
        tomatoDirtFinalStage.SetActive(false);
        plantString.text = "Place seeds to Learn more about Gardening.";
    }

    // Update is called once per frame
    void Update()
    {
        if(seedCounter == 5)
        {
            unseededDirt.SetActive(false);
            tomatoDirtStage1.SetActive(true);
            plantString.text = "Take 2 - 3 seeds and place them into a  ¼ in deep pocket in the soil and then sprinkle soil to cover the pocket. Make sure that the pockets of seeds are planted about an inch away from each other.";
            seedCounter++;
        }

        if(waterCounter == 30 && seedCounter > 5)
        {
            tomatoDirtStage1.SetActive(false);
            tomatoDirtStage2.SetActive(true);
            plantString.text = "Water plants 1 to 2 times a day depending on how warm the weather is.";
        }

        if (waterCounter == 60 && seedCounter > 5)
        {
            tomatoDirtStage2.SetActive(false);
            tomatoDirtStage3.SetActive(true);
            plantString.text = "Needs 6-8 hours of direct sunlight for optimal growth!";
        }

        if (waterCounter == 120 && seedCounter > 5)
        {
            tomatoDirtStage3.SetActive(false);
            tomatoDirtFinalStage.SetActive(true);
            plantString.text = "Once the crop has begun to grow leaves, it will take around 2-3 months for tomatoes to grow and be harvested!";
        }
    }
}
