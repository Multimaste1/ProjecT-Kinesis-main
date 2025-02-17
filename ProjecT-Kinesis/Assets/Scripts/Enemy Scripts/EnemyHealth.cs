using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int enemyMaxHealth;
    public int health;

    public Score score;

    // Start is called before the first frame update
    void Start()
    {
        health=enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamage(int damage)
    {
        health = health - damage;
        if (health <= 0)
        {
            score.score +=25;
            Destroy(gameObject);
        }
    }
}
