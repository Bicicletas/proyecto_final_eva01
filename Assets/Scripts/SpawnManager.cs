using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject coin;

    private Vector3 spawnPos;
    private Vector3 spawnScale;

    private float lowRandomScale = 3f;
    private float highRandomScale = 10f;

    private float xRange = 150;
    private float yRange = 150;
    private float zRange = 150;
    private float yLowRange = 30;

    private float startTime = 1f;
    private float repeatRate = 5f;

    private int maxCoins = 9;
    
    

    void Start()
    {
        InvokeRepeating("SpawnPrefab", startTime, repeatRate);

        for (int i = 0; i <= maxCoins; i++)
        {
            Instantiate(coin, RandomSpawnPos() + RandomScale(), coin.transform.rotation);
        }
    }

    public Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-xRange, xRange);
        float randomY = Random.Range(yLowRange, yRange);
        float randomZ = Random.Range(-zRange, zRange);
        
        return new Vector3(randomX, randomY, randomZ);
    }
    public void SpawnPrefab()
    {
        spawnScale = RandomScale();
        spawnPos = RandomSpawnPos();
        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
    }

    public Vector3 RandomScale()
    {
        float scaleX = Random.Range(lowRandomScale, highRandomScale);
        float scaleY = Random.Range(lowRandomScale, highRandomScale);
        float scaleZ = Random.Range(lowRandomScale, highRandomScale);

        return obstacle.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
    }
}
