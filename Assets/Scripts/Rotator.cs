using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    //public float speed = 50f;
    public float speed;
    float newspeed = RotatorManager.RotateSpeed;

    void Update ()
    {
        transform.Rotate(0f, 0f, speed * newspeed * Time.deltaTime);
    }
}
