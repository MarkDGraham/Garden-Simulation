using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextUpdater : MonoBehaviour
{
    public string plantName;
    public string stage;
    public Text factInformation;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if(plantName == "Tomato" && stage == "Stage1")
        {
            factInformation.text = "Stage 1";
        }
    }
}
