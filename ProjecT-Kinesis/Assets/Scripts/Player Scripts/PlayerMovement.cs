using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speedMultiplier; //player speed multiplier

    public FlightUpgrade FlightUpgrade;


    // Start is called before the first frame update
    void Start()
    {
        switch (FlightUpgrade.UpgradeLevel)
        {
            case 0: 
                speedMultiplier = 2; break; //base movement speed
            case 1: 
                speedMultiplier = 5; break;
            case 2: 
                speedMultiplier = 6; break;
            case 3: 
                speedMultiplier = 7; break;
            case 4:
                speedMultiplier = 8; break;
            case 5:
                speedMultiplier = 9; break;
            default:
                break; //avoid an error if level is somehow not 0 to 5

        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); //Vector 2 is made taking vertical and horizontal input
        transform.position += (Vector3)(movement * speedMultiplier * Time.deltaTime); //smoothly offsets the players position no matter the frame rate
        
    }

    private void FixedUpdate()
    {
       
    }
}
