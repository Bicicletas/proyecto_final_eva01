using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(projectilePrefab, transform.position, gameObject.transform.rotation);
        }
    }
}
