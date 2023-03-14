using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float ramdomX = Random.Range(-xSpawnRange, xSpawnRange);
        int RandomIndex = RandomIndex.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(RandomIndex, ySpawn, zEnemySpawn);

        Instantiate(enemies[RandomIndex], spawnPos, enemies[RandomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float ramdomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, PowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
    }
}
