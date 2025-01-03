using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D Rigidbody;
    public float projectileVelocity;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        Rigidbody.velocity = new Vector2 (direction.x, direction.y).normalized * projectileVelocity;

        float projectileRotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0, projectileRotation - 45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
