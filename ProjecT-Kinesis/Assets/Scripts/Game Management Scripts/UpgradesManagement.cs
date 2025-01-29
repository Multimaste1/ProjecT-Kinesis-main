using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UpgradesManagement : MonoBehaviour
{

   

    
    private float healthCost =10; //stores baseCosts of upgrades
    private float flightCost = 10;
    private float sizeCost = 10;
    private float velocityCost = 10;


    public TextMeshProUGUI coinstext;



    public Sprite[] upgradeBars; //array to store the different levels of the upgrade bar
    private Image currentupgradeBar; //image component that stores the upgrade bar
    public int currentLevel = 0; //stores position of level in the array

    public Coins coins; //allows upgrades to access the Coins scriptable object


    
    // Start is called before the first frame update
    void Start()
    {
        currentupgradeBar = GetComponent<Image>(); // stores image component of the upgrade bar

        coinstext.text = "Coins:" + coins.coinbalance.ToString();
    }

    // Update is called once per frame

    public void upgradeHealth()
    {
        if (currentLevel < upgradeBars.Length && coins.coinbalance >= (healthCost)) //if max level isn't reached and coin balance > cost
        {
            currentupgradeBar.sprite = upgradeBars[currentLevel];
            currentLevel += 1; //increments through upgrade levels

            coins.coinbalance -= Mathf.FloorToInt(healthCost); //takes away upgrade cost from amount of coins
            healthCost = healthCost * 1.5f;
            coinstext.text = "Coins:" + coins.coinbalance.ToString(); //changes coin text to display coin total after upgrade purchase
            Debug.Log(coins.coinbalance);
        }
        else //if max level (5) is reached 
        {
            Debug.Log("max level");
            return; //exits the function
        }
    }

    public void upgradeFlight()
    {
        if (currentLevel < upgradeBars.Length && coins.coinbalance >= (flightCost)) 
        {
            currentupgradeBar.sprite = upgradeBars[currentLevel];
            currentLevel += 1; 

            coins.coinbalance -= Mathf.FloorToInt(flightCost); 
            flightCost = flightCost * 1.5f;
            coinstext.text = "Coins:" + coins.coinbalance.ToString(); 
            Debug.Log(coins.coinbalance);
        }
        else 
        {
            Debug.Log("max level");
            return; 
        }
    }

    public void upgradeSize()
    {
        if (currentLevel < upgradeBars.Length && coins.coinbalance >= (sizeCost)) 
        {
            currentupgradeBar.sprite = upgradeBars[currentLevel];
            currentLevel += 1; 

            coins.coinbalance -= Mathf.FloorToInt(sizeCost); 
            sizeCost = sizeCost * 1.5f;
            coinstext.text = "Coins:" + coins.coinbalance.ToString();
            Debug.Log(coins.coinbalance);
        }
        else //if max level (5) is reached 
        {
            Debug.Log("max level");
            return; 
        }
    }

    public void upgradeVelocity()
    {
        if (currentLevel < upgradeBars.Length && coins.coinbalance >= (velocityCost)) 
        {
            currentupgradeBar.sprite = upgradeBars[currentLevel];
            currentLevel += 1; 
            coins.coinbalance -= Mathf.FloorToInt(velocityCost); 
            velocityCost = velocityCost * 1.5f;
            coinstext.text = "Coins:" + coins.coinbalance.ToString(); 
            Debug.Log(coins.coinbalance);
        }
        else 
        {
            Debug.Log("max level");
            return;
        }
    }
}
