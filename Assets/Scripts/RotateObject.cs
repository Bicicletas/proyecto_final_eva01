using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public float turnSpeed = 20f;

    void Update()
    {
       transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }
}
