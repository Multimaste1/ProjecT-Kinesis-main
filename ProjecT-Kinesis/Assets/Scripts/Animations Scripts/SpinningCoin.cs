using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinningCoin : MonoBehaviour
{

    public Sprite[] frames; //array to store frames
    public float frameRate = 0.1f; //changes framerate of the animation; 0.1f = 10 fps; determines how long each sprite fram should display before switching
    public Image imageComponent; //compenent of image
    private int currentFrame; //stores the value of current frame to be shown from the array
    private float timer; //variable that counts up to how long frame should show


    // Start is called before the first frame update
    void Start()
    {
        imageComponent = GetComponent<Image>(); //gets the image component at run time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime; //increases the timer variable by the time which has passed since the last frame
        if (timer > frameRate) //if statements to have animation be frame rate independent; when timer exceeds frame rate that's when the sprite should switch
        {
            timer = 0f; //resets the timer if it is larger than the frame rate
            currentFrame = (currentFrame+1) % frames.Length;//moves to the next frame in the array //mod frames.length makes the array loop back to start 
            imageComponent.sprite = frames[currentFrame]; //updates the sprite component of the image to show the current frame of the array
        }
    }
}