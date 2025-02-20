using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectedProjectileBehaviour : MonoBehaviour
{
    public int damage; //parameters of takedamage function
    public int enemyScore;
    public int bossScore;

    private GameObject orb; //private gameobjects and components accessed by code rather put in through inspector
    private GameObject enemy;
    private Rigidbody2D reflectedprojectileRigidBody;

    public Difficulty difficulty; //difficulty scriptable object


    public float reflectedprojectileVelocity; //scalar velocity set in inspector

    // Start is called before the first frame update
    void Start()
    {
        reflectedprojectileRigidBody = GetComponent<Rigidbody2D>(); //accesses rigid body component of reflectprojectile
        
        int randomNumber  = Random.Range(1, 2);
        switch (randomNumber) //projectile will either go towards Boss or enemy; this allows me to keep the enemy health and boss health variables in seperate scripts
        {
            case 1: 
                enemy = GameObject.FindGameObjectWithTag("Enemy"); //projectile will find enemy game object
                break;
            case 2:
                enemy = GameObject.FindGameObjectWithTag("Boss");
                break;
        }
        

        Vector3 direction = enemy.transform.position - transform.position; //sets direction for projectile to travel towards enemy
        reflectedprojectileRigidBody.velocity = new Vector2(direction.x, direction.y).normalized * reflectedprojectileVelocity;

        float reflectedprojectileRotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;//angle of rotation that projectile needs to face towards player; converts from radians to degrees 
        transform.rotation = Quaternion.Euler(0, 0, reflectedprojectileRotation + 45);//adjusts rotation so that graphic of projectile is correct


        switch (difficulty.difficulty) //cases dependning on difficulty selected which changes score that enemies provide
        {
            case 1:
                enemyScore = 15;
                bossScore = 200;
                break;
            case 2:
                enemyScore = 25;
                bossScore = 300;
                break;
            case 3:
                enemyScore = 50;
                bossScore = 500;
                break;
            default:
                enemyScore = 15;
                bossScore = 200;
                break;
        }
    }

    // Update is called once per frame

    public void OnCollisionEnter2D(Collision2D collision)
    {
        reflectedOrb(collision); //creates specific collision function for when reflected projectile projectile hits enemy
    }

    public void reflectedOrb(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) //checks if tag of object is enemy and if it is runs take damage function from EnemyHealth script
        {
            Debug.Log("hit");
            collision.gameObject.GetComponent<EnemyHealth>().takedamage(damage, enemyScore); //gets the Enemy script from the enemy and runs the takedamage function
            Destroy(gameObject); //destroys projectile
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<BossHealth>().takedamage(damage, bossScore);
            Destroy(gameObject);
        }
    }
}
