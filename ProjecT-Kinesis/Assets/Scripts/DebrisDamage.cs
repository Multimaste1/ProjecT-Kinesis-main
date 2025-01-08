using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisDamage : MonoBehaviour
{

    public int damage;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player")) //checks if tag of object is Player and if it is runs take damage function from PlayerHealth script
        {
            Debug.Log("hit");
            collision.gameObject.GetComponent<PlayerHealth>().takedamage(damage);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }

        
    }
    
}
