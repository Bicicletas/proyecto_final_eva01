using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float hRange = 200f;
    private float vRange = 200f;
    private float zRange = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

        if (transform.position.y > vRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < 0)
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
