using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    private float length;
    public GameObject mainCamera;
    public float parallaxEffect;
    public float speed;

    public void Start()
    {
        
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    public void Update()
    {
        float dist = (mainCamera.transform.position.x * parallaxEffect) + (-speed * Time.time);
        transform.position = new Vector3(dist, transform.position.y, transform.position.z);

        // Check if the background has moved out of view, then reposition it
        float camLeftEdge = mainCamera.transform.position.x - length; // Camera's left edge
        if (transform.position.x < camLeftEdge)
        {
            transform.position += new Vector3(length * 2, 0, 0); // Move to the right
        }
    }

    
}
