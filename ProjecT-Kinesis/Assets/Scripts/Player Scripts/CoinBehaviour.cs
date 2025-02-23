using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinBehaviour : MonoBehaviour 
{
    public Coins coins;
    public Score score;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coins.coinbalance += 5;
            score.score += 50;
            FindAnyObjectByType<AudioManager>().playSound("Coin");
            Debug.Log("score Up");
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Orb"))
        {
            coins.coinbalance += 5;
            score.score += 50;
            FindAnyObjectByType<AudioManager>().playSound("Coin");
            Debug.Log("score Up");
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}

   

