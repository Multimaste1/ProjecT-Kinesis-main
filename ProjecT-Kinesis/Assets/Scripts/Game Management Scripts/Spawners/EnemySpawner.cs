using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy; //variable to spawn Enemy and Boss prefab
    public GameObject Boss;
    public GameObject bossSpawnPointGameObject;

    public float spawnAreaMinX; //variables to store min and max transform values of where enemies can spawn
    public float spawnAreaMinY;
    public float spawnAreaMaxX;
    public float spawnAreaMaxY;

    public float spawnInterval;
    public int bossTimer;

    private bool bossSpawned = false;

    public Timer timer;
    public Difficulty difficulty;

    // Start is called before the first frame update
    void Start()
    {
        switch (difficulty.difficulty) //cases dependning on difficulty selected which changes projectile velocity
        {
            case 1:
                spawnInterval = 6f;
                break;
            case 2:
                spawnInterval = 4f;
                break;
            case 3:
                spawnInterval = 2f;
                break;
            default:
                spawnInterval = 6f;
                break;
        }
        InvokeRepeating("spawnEnemy", 5f, spawnInterval);   
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer.timerCount);
        if (!bossSpawned && timer.timerCount >= bossTimer) //if bossSpawned=false and timerCount exceeds bossTimer, boss is spawned once; bossSpawned is set back to true
        {
            bossSpawned = true;
            Debug.Log("Boss spawning at" + timer.timerCount); //shows time at which boss spanws which should be equal to bossTimer
            spawnBoss();
            FindAnyObjectByType<AudioManager>().playSound("BossRoar");
        }
    }

    public void spawnEnemy() //function to spawn in enemy in random location
    {
        float randomX = Random.Range(spawnAreaMinX, spawnAreaMaxX);
        float randomY = Random.Range(spawnAreaMinY,spawnAreaMaxY);
        Vector3 spawnPoint = new Vector3(randomX, randomY, 0);
        Instantiate(Enemy, spawnPoint, Quaternion.Euler(0,180,0)); //"180" flips the sprite so it faces the player
    }

    public void spawnBoss() //function to spawn boss
    {
        Vector3 bossSpawnPoint = new Vector3(bossSpawnPointGameObject.transform.position.x, bossSpawnPointGameObject.transform.position.y,0);
        Instantiate(Boss, bossSpawnPoint, Quaternion.identity);
    }
}

