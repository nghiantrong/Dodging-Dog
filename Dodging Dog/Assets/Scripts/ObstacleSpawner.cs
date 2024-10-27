using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate;
    public float maxXposition;

    void Start()
    {
        StartSpawning();
    }

    void Update()
    {

    }

    void Spawn()
    {
        float randomX = Random.Range(-maxXposition, maxXposition);

        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, spawnPosition, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
}
