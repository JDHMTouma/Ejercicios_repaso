using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenObstacle : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    [Range(0, 10)]
    public float spawnRandomRange;
    [Range(0, 10)]
    public float timeBetween;
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, timeBetween);
    }
    void Spawn()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-spawnRandomRange, spawnRandomRange), 0f, 0f);
        Instantiate(obstaclePrefabs, transform.position + randomPosition, Quaternion.identity);
    }

}
