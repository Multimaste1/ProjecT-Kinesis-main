using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    
    public int Health;
    
    public int maxHealth;

    public HealthUpgrade HealthUpgrade;

    public HighscoreUI HighscoreUI;

    public Score score;
    public Highscore highscore;
    public Coins coins;

    void Start()
    {
        coins.LoadData();
        HealthUpgrade.LoadData();
        switch (HealthUpgrade.UpgradeLevel) //different health values depending on upgrade level stored in Health Upgrade SO
        {
            case 0: 
                maxHealth = 3; break; //base health
            case 1:
                maxHealth = 4; break;
            case 2:
                maxHealth = 5; break;
            case 3:
                maxHealth = 6; break;
            case 4:
                maxHealth = 7; break;
            case 5:
                maxHealth = 8; break;
            default:
                break;
        }

        Health = maxHealth;
    }
    public void takedamage(int damage)
    {
        Health = Health - damage;
        if (Health <= 0)
        {
            HighscoreUI.checkScore(score,highscore);
            Debug.Log("Checking score");
            coins.SaveData();
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }


    
    
}
