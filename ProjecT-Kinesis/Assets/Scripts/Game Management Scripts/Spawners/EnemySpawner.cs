using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy; //variable to spawn Enemy and Boss prefab
    public GameObject Boss;
    public GameObject bossSpawnPointGameObject;

    public float spawnAreaMinX; //variables to store min and max transform values of where coins can spawn
    public float spawnAreaMinY;
    public float spawnAreaMaxX;
    public float spawnAreaMaxY;

    public float spawnInterval;
    public int bossTimer;

    private bool bossSpawned = false;

    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 2f, spawnInterval);   
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer.timerCount);
        if (!bossSpawned && timer.timerCount >= bossTimer)
        {
            bossSpawned = true;
            Debug.Log("Boss spawning at" + timer.timerCount);
            spawnBoss();
        }
    }

    public void spawnEnemy()
    {
        float randomX = Random.Range(spawnAreaMinX, spawnAreaMaxX);
        float randomY = Random.Range(spawnAreaMinY,spawnAreaMaxY);
        Vector3 spawnPoint = new Vector3(randomX, randomY, 0);
        Instantiate(Enemy, spawnPoint, Quaternion.identity);
    }

    public void spawnBoss()
    {
        Vector3 bossSpawnPoint = new Vector3(bossSpawnPointGameObject.transform.position.x, bossSpawnPointGameObject.transform.position.y,0);
        Instantiate(Boss, bossSpawnPoint, Quaternion.identity);
    }
}

