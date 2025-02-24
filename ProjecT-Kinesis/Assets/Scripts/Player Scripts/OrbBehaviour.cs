using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbofProtection : MonoBehaviour
{
    // Start is called before the first frame update

    public float speedMultiplier;
    public GameObject reflectedProjectile;
    public Transform reflectedProjectilePos;

    public VelocityUpgrade VelocityUpgrade;
    public SizeUpgrade SizeUpgrade;
    void Start()
    {
        VelocityUpgrade.LoadData();
        SizeUpgrade.LoadData();

        switch (VelocityUpgrade.UpgradeLevel) //different cases for different upgrade levels; upgrades are applied at the start of the scene
        {
            case 0: 
                speedMultiplier = 2f; break;
            case 1: 
                speedMultiplier =4f; break;
            case 2:
                speedMultiplier =6f; break;
            case 3: 
                speedMultiplier =8f; break;
            case 4: 
                speedMultiplier =10f; break;
            case 5: 
                speedMultiplier =12f; break;
            default: 
                break;
        }

        switch (SizeUpgrade.UpgradeLevel) //different cases for different upgrade levels; upgrades are applied at the start of the scene
        {
            case 0:
                transform.localScale= new Vector3(0.1f, 0.1f, 1); break; //changes scale of orb sprite component
            case 1:
                transform.localScale = new Vector3(0.125f,0.125f,1); break;
            case 2:
                transform.localScale = new Vector3(0.130f, 0.130f, 1); break;
            case 3:
                transform.localScale = new Vector3(0.135f, 0.135f, 1); break;
            case 4:
                transform.localScale = new Vector3(0.140f, 0.140f, 1); break;
            case 5:
                transform.localScale = new Vector3(0.150f, 0.150f, 1); break;

        }
        
    }

    public void FollowMouse() //gets current mouse position and transforms orb to it
    {
        //stores mousePosition vector
        Vector2 mousePosition = Input.mousePosition;
        

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        // Smoothly move orb toward the mouse position
        transform.position = Vector2.Lerp(transform.position, new Vector2(mousePosition.x, mousePosition.y), speedMultiplier * Time.deltaTime);
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
        FindAnyObjectByType<AudioManager>().playSound("Reflection");
    }
}
    

