using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D Rigidbody;
    public float projectileVelocity;
    // Start is called before the first frame update

    private GameObject orb;
    private GameObject enemy;
    
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>(); //accesses rigid body component of projectile
        player = GameObject.FindGameObjectWithTag("Player"); //finds Player game object

        Vector3 direction = player.transform.position - transform.position; //sets direction for projectile to travel towards player
        Rigidbody.velocity = new Vector2 (direction.x, direction.y).normalized * projectileVelocity;

        float projectileRotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;//angle of rotation that projectile needs to face towards player; converts from radians to degrees 
        transform.rotation = Quaternion.Euler(0,0, projectileRotation);//adjusts rotation so that graphic of projectile is correct
    }


    // Update is called once per frame
    void Update()
    {




    }
    public void OnCollisionEnter2D(Collision2D collision) //deletes the projectile when it hits the orb
    {
        orbCollision(collision);
    }

    public void orbCollision(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Orb"))
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }

}
