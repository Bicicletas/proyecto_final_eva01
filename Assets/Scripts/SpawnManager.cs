using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject coin;
    private Vector3 spawnPos;
    private float randomX;
    private float randomY;
    private float randomZ;
    private int randomIndex;
    private float xRange = 100;
    private float yRange = 100;
    private float zRange = 100;
    private float startTime = 1f;
    private float repeatRate = 5f;
    private int maxCoins = 9;
    

    void Start()
    {
        InvokeRepeating("SpawnPrefab", startTime, repeatRate);

        for (int i = 0; i <= maxCoins; i++)
        {
            Instantiate(coin, RandomSpawnPos(), coin.transform.rotation);
        }
    }

    public Vector3 RandomSpawnPos()
    {
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(0, yRange);
        randomZ = Random.Range(-zRange, zRange);
        return new Vector3(randomX, randomY, randomZ);
    }
    public void SpawnPrefab()
    {
        spawnPos = RandomSpawnPos();
        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
    }
}
