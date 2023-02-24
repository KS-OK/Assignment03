using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNameExit : MonoBehaviour
{
    string showmyname = NameTransfer.theName;
    public GameObject displayText;

    public void Start()
    {
        displayText.GetComponent<Text>().text = "Too bad, " + showmyname + "!";
    }
}
