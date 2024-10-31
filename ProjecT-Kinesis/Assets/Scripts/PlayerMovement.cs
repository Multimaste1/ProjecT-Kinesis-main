using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private float speed=5f; //player speed is set
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); //Vector 2 is made taking vertical and horizontal input
        transform.position += (Vector3)(movement * speed * Time.deltaTime); //smoothly offsets the players position no matter the frame rate
        
    }

    private void FixedUpdate()
    {
       
    }
}
