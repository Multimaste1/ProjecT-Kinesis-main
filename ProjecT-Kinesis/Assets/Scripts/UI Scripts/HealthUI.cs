using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public int health; //stores current health of player
    public int maxHealth; //stores maximum health of player; maximum amount of hearts

    public Sprite EmptyHeart; //stores sprite for empty heart
    public Sprite FullHeart; //stores sprite for full heart
    public Image[] hearts; //list to store all sprites for hearts

    public PlayerHealth playerHealth; //reference to playerHealth script

    
    // Start is called before the first frame update
    void Start()
    {
        health=playerHealth.Health; //health is set to equal health in playerHealth script
        maxHealth = playerHealth.maxHealth; //maxHealth is set to equal maxHealth in playerHealth script
    }

    // Update is called once per frame
    void Update()
    {
        health = playerHealth.Health; //health and maxHealth are constantly checked to see if they are equal to player Health and MaHealth in playerHealth script
        maxHealth = playerHealth.maxHealth;
        for (int i = 0; i < hearts.Length; i++) //for loop to cycle through how many hearts the player has
        {
            if (i < health) 
            {
                hearts[i].sprite = FullHeart; //sets all hearts present to fullheart
            }
            else
            {
                hearts[i].sprite = EmptyHeart; //sets all the other hearts to empty hearts; i.e. health has been lost
            }

            if (i < maxHealth) //will show how the maximum amount of hearts the player will have
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled=false;
            }
        }
    }
}
