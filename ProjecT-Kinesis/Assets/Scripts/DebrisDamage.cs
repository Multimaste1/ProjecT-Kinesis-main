using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisDamage : MonoBehaviour
{
    public PlayerHealth playerhealth;
    // Start is called before the first frame update
    public int damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerhealth.takedamage(damage);
        }
    }
    
}
