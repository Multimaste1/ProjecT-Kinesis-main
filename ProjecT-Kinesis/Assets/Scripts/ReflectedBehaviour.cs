using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectedProjectileBehaviour : MonoBehaviour
{
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
    void Update()
    {
        
    }
}
