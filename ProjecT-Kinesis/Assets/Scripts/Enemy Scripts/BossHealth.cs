using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BossHealth : MonoBehaviour
{

    [SerializeField]
    private int bossMaxHealth = 30; //boss doesn't have difficulty SO attached to it so I can just change its health in the inspector
    [SerializeField]
    private int bossHealth;

    public Difficulty difficulty;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        difficulty.LoadData();
        switch (difficulty.difficulty) //cases dependning on difficulty selected which change enemy health
        {
            case 1:
                bossMaxHealth = 20;
                break;
            case 2:
                bossMaxHealth = 30;
                break;
            case 3:
                bossMaxHealth = 50;
                break;
            default:
                bossMaxHealth = 20;
                break;
        }
        bossHealth = bossMaxHealth;
    }

    // Update is called once per frame
    public void takedamage(int damage, int bossScore) //values for damage and enemyScore parameters are passed through in ReflectedBehaviour script
    {
        bossHealth = bossHealth - damage;
        if (bossHealth <= 0)
        {
            score.score += bossScore;
            Debug.Log("scoreup");
            Destroy(gameObject);
        }
    }
}
