using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public float enemySpeed; //variable to store speed at which enemy moves
    public float enemyMaxDistance; //variable that stores how far enemy can move from spawn point
    public float range; //how close enemy needs to be to the way point - range till new waypoint set


    public GameObject projectile;
    public Transform projectilePos;

    public float timer;
    Vector2 wayPoint; //destination for enemy to go towards

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, enemySpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            setNewDestination();
        }
        //fix needs to be that a new waypoint is set if transform position is outside of range set by borders

        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            shoot();
        }

        void setNewDestination()
        {
            wayPoint = new Vector2(Random.Range(-enemyMaxDistance, enemyMaxDistance), Random.Range(-enemyMaxDistance, enemyMaxDistance));
        }

        void shoot()
        {
            Instantiate(projectile, projectilePos.position, Quaternion.identity);
        }
    }
}
