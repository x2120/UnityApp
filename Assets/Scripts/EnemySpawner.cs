using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour

{
    public GameObject EnemyGO;

    float maxSpawnRateInSeconds = 5f;

    void Start()
    {
        invoke("SpawnEnemy", maxSpawnRateInSeconds);

        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);

    }

    void Update()
    {

    }

    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWordPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWordPoint(new Vector2(1, 1));

        GameObject anEnemy = (GameObject)Instantiate(EnemyGO);
        anEnemy.Enemy.transform.postion = new vector2(Random.Range(min.x, max.x), max.y);

        scheduleNextEnemySpawn();

    }

    void scheduleNextEnemySpawn()
    {
        float spawnInNSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            spawnInNSeconds = Random.Range(1f, maxSpawnRateInSeconds);

        }
        else spawnInNSeconds = 1f;

        invoke("SpawnEnemy", spawnInNSeconds);

    }

    void IncreaseSpawnrate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;
        if (maxSpawnRateInSeconds == 1f)
            cancleInvoke("IncreaseSpawnRate");


    }



}