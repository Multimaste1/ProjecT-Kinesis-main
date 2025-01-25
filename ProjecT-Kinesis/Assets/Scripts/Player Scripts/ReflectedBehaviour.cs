using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectedProjectileBehaviour : MonoBehaviour
{
    public int damage;
    private GameObject orb;
    private GameObject enemy;
    private Rigidbody2D reflectedprojectileRigidBody;

    public float reflectedprojectileVelocity;

    // Start is called before the first frame update
    void Start()
    {
        reflectedprojectileRigidBody = GetComponent<Rigidbody2D>(); //accesses rigid body component of reflectprojectile
        enemy = GameObject.FindGameObjectWithTag("Enemy"); //finds enemy game object
        Vector3 direction = enemy.transform.position - transform.position; //sets direction for projectile to travel towards player
        reflectedprojectileRigidBody.velocity = new Vector2(direction.x, direction.y).normalized * reflectedprojectileVelocity;

        float reflectedprojectileRotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;//angle of rotation that projectile needs to face towards player; converts from radians to degrees 
        transform.rotation = Quaternion.Euler(0, 0, reflectedprojectileRotation + 45);//adjusts rotation so that graphic of projectile is correct
    }

    // Update is called once per frame

    public void OnCollisionEnter2D(Collision2D collision)
    {
        reflectedOrb(collision);
    }

    public void reflectedOrb(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) //checks if tag of object is enemy and if it is runs take damage function from EnemyHealth script
        {
            Debug.Log("hit");
            collision.gameObject.GetComponent<EnemyHealth>().takedamage(damage); //gets the Enemy script from the enemy and runs the takedamage function
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}
