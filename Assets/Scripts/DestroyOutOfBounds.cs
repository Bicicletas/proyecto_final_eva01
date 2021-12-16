using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float hRange = 400f;
    private float yRange = 400f;
    private float zRange = 400f;

    void Update()
    {
        if (transform.position.x > hRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -hRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > yRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < -yRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -zRange)
        {
            Destroy(gameObject);
        }
    }
}
