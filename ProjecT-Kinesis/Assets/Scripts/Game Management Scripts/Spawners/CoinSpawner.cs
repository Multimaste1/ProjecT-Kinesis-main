using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin; //variable to spawn coin prefab
    public float spawnAreaMinX; //variables to store min and max transform values of where coins can spawn
    public float spawnAreaMinY;
    public float spawnAreaMaxX;
    public float spawnAreaMaxY;

    public float spawnInterval; //float to store rate at which coins spawn

    public void Start()
    {
        InvokeRepeating("spawnCoin", 5f, spawnInterval); //spawns coins after initial seconds have passed, then at a rate of "spawnInterval" afterwards
    }

    public void spawnCoin() //function to spawn in coin
    {
        float randomX = Random.Range(spawnAreaMinX, spawnAreaMaxX);
        float randomY = Random.Range( spawnAreaMinY, spawnAreaMaxY);
        Vector3 spawnPoint = new Vector3(randomX, randomY, 0);
        Instantiate(Coin, spawnPoint, Quaternion.identity);
    }
}
