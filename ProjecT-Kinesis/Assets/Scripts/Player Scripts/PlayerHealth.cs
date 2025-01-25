using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int playerMaxHealth = 10;
    public int Health;

    void Start()
    {
        Health = playerMaxHealth;
    }
    public void takedamage(int damage)
    {
        Health = Health - damage;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }


    
    
}
