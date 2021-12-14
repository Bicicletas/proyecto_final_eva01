using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision otherCollider)
    {

        if (gameObject.CompareTag("Obstacle") && otherCollider.gameObject.CompareTag("Proyectil"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);

        }

        if (gameObject.CompareTag("Obstacle") && otherCollider.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
        }



    }
}
