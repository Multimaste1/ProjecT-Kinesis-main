using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int enemyMaxHealth; //boss doesn't have difficulty SO attached to it so I can just change its health in the inspector
    [SerializeField]
    private int health;
    

    public Score score;
    public Difficulty difficulty;

    // Start is called before the first frame update
    void Start()
    {
        difficulty.LoadData();
        switch (difficulty.difficulty) //cases dependning on difficulty selected which change enemy health
        {
            case 1: 
                enemyMaxHealth = 1;  
                break;
            case 2: 
                enemyMaxHealth = 3;  
                break;
            case 3:
                enemyMaxHealth = 5; 
                break;
            default: 
                enemyMaxHealth = 1; 
                break;
        }
        health = enemyMaxHealth;
    }

    public void takedamage(int damage, int enemyScore) //values for damage and enemyScore parameters are passed through in ReflectedBehaviour script
    {
        health = health - damage;
        if (health <= 0)
        {
            score.score +=enemyScore;
            Debug.Log("scoreup");
            Destroy(gameObject);
        }
    }
}
