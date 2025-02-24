using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public int damage;


    private GameObject player;
    private Rigidbody2D Rigidbody;
    [SerializeField]
    private float projectileVelocity;
    // Start is called before the first frame update

    private GameObject orb;
    private GameObject enemy;

    public Difficulty difficulty;
    
    void Start()
    {
        difficulty.LoadData();
        switch (difficulty.difficulty) //cases dependning on difficulty selected which changes projectile velocity
        {
            case 1:
                projectileVelocity = 5;
                break;
            case 2:
                projectileVelocity = 10;
                break;
            case 3:
                projectileVelocity = 15;
                break;
            default:
                projectileVelocity = 5;
                break;
        }

        Rigidbody = GetComponent<Rigidbody2D>(); //accesses rigid body component of projectile
        player = GameObject.FindGameObjectWithTag("Player"); //finds Player game object

        Vector3 direction = player.transform.position - transform.position; //sets direction for projectile to travel towards player
        Rigidbody.velocity = new Vector2 (direction.x, direction.y).normalized * projectileVelocity; //normalised converts the direction into a unit vector so that projectile travels at a constant speed no matter the direction

        float projectileRotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;//angle of rotation that projectile needs to face towards player; converts from radians to degrees 
        transform.rotation = Quaternion.Euler(0,0, projectileRotation);//adjusts rotation so that graphic of projectile is correct
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        orbCollision(collision); //creates an OncollisionEnter2D function called orbCollision which is easier to call upon

    }

    public void orbCollision(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //checks if tag of object is Player and if it is runs take damage function from PlayerHealth script
        {
            Debug.Log("hit");
            collision.gameObject.GetComponent<PlayerHealth>().takedamage(damage); //gets the PlayerHealth script from the player and runs the takedamage function
            Destroy(gameObject);
            FindAnyObjectByType<AudioManager>().playSound("PlayerHurt");
        }

        if (collision.gameObject.CompareTag("Platform")) //destroys the projectile if it colides with the players platform
        {
            Destroy(gameObject);
            FindAnyObjectByType<AudioManager>().playSound("PlatformHit");
        }
        if (collision.gameObject.CompareTag("Orb")) //destroys the projectile if it collides with the orb
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }

}
