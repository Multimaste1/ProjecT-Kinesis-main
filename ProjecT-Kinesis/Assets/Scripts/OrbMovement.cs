using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbofProtection : MonoBehaviour
{
    // Start is called before the first frame update

    float minX;
    float maxX;
    float minY;
    float maxY;
    void Start()
    {
        //defines screen boundaries
        minX = 0;
        maxX = Screen.width;
        minY = 0;
        maxY = Screen.height;
    }

    public void FollowMouse() //gets current mouse position and transforms orb to it
    {
        //stores mousePosition vector
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.x = Mathf.Clamp(mousePosition.x, minX, maxX); //restricts the x position of the mouse between the set boundary
        mousePosition.y = Mathf.Clamp(mousePosition.y, minY, maxY); //restricts the y position of the mouse between the set boundary

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector2(mousePosition.x, mousePosition.y); //moves the orb according to mouse position
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
      
    }

}
    

