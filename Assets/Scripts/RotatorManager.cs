using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorManager : MonoBehaviour
{
    public static float RotateSpeed;
    public Slider ChangeSpeed;
    public Text ShowSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AdjustSpeed()
    {
        RotateSpeed = ChangeSpeed.value;
        ShowSpeed.text = "Rotator speed: " + RotateSpeed.ToString();
    }
}