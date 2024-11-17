using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisDamage : MonoBehaviour
{
    public PlayerHealth playerhealth;
    public int damage;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerhealth.takedamage(damage);
        }
    }
    
}
