using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour 
{
    public Coins coins;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coins.coinbalance += 5;
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Orb"))
        {
            coins.coinbalance += 5;
            Destroy(gameObject);
        }
    }
}

   

