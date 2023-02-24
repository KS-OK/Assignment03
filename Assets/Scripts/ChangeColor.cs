using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public GameObject PlayerCircle;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCircle.GetComponent<Renderer>().material.color = Color.black;
    }

    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                PlayerCircle.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                PlayerCircle.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 3:
                PlayerCircle.GetComponent<Renderer>().material.color = Color.green;
                break;
        }
        }
}
