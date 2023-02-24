using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    int showthescore = Score.PinCount;
    public GameObject displayText;

    // Start is called before the first frame update
    void Start()
    {
        displayText.GetComponent<Text>().text = "Score was " + showthescore + "!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
