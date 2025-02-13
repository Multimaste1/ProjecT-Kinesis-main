using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    public float spawnAreaMinX;
    public float spawnAreaMinY;
    public float spawnAreaMaxX;
    public float spawnAreaMaxY;

    public float spawnInterval;

    public void Start()
    {
        InvokeRepeating("spawnCoin", 5f, spawnInterval);
    }

    public void spawnCoin()
    {
        float randomX = Random.Range(spawnAreaMinX, spawnAreaMaxX);
        float randomY = Random.Range( spawnAreaMinY, spawnAreaMaxY);
        Vector3 spawnPoint = new Vector3(randomX, randomY, 0);
        Instantiate(Coin, spawnPoint, Quaternion.identity);
    }
}
