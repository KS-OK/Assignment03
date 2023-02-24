using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    string showmyname = NameTransfer.theName;
    public GameObject displayText;

    public void Start ()
    {
        displayText.GetComponent<Text>().text = "You are " + showmyname + "!";
    }
}
