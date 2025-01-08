using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbofProtection : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public GameObject reflectedProjectile;
    public Transform reflectedProjectilePos;

    void Start()
    {
        
        
    }

    public void FollowMouse() //gets current mouse position and transforms orb to it
    {
        //stores mousePosition vector
        Vector2 mousePosition = Input.mousePosition;
        

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        // Smoothly move orb toward the mouse position
        transform.position = Vector2.Lerp(transform.position, new Vector2(mousePosition.x, mousePosition.y), speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
        
      
    }

    public void reflection()
    {
        Instantiate(reflectedProjectile, reflectedProjectilePos.position,Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        reflection();
    }
}
    

