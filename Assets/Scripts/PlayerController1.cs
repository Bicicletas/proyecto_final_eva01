using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 20f;
    public float turnSpeed = 20f;
    private float hRange = 200f;
    private float vRange = 200f;
    private float zRange = 200f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 100, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * turnSpeed * Time.deltaTime * verticalInput);



        if (transform.position.x > hRange)
        {
            transform.position = new Vector3(hRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -hRange)
        {
            transform.position = new Vector3(-hRange, transform.position.y, transform.position.z);
        }

        if (transform.position.y > vRange)
        {
            transform.position = new Vector3(transform.position.x, vRange, transform.position.z);
        }
        else if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        else if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
    }
}
