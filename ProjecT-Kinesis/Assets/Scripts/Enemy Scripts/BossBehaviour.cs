using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{

    public GameObject projectile;
    public Transform projectilePos;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 2f, 0.1f); //need to make it a burst attack
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void shoot()
    {
        
        
            Instantiate(projectile, projectilePos.position, Quaternion.identity); //spawns in 3 projectiles at once
        
    }
}
