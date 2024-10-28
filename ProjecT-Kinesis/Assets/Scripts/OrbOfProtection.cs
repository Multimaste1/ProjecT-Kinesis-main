using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbofProtection : MonoBehaviour
{
    // Start is called before the first frame update

    
    //defines boundaries of screen window
    float minX;
    float maxX;
    float minY;
    float maxY;
    void Start()
    {
        minX = 50;
        maxX = Screen.width - 50;
        minY = 50;
        maxY = Screen.height - 50;
    }

    public void FollowMouse() //gets current mouse position and transforms orb to it
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.x = Mathf.Clamp(mousePosition.x, minX, maxX);
        mousePosition.y = Mathf.Clamp(mousePosition.y, minY, maxY);

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector2(mousePosition.x, mousePosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
       
       

        
        
    }

}
    

