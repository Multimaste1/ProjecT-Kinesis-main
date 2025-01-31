using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using System.Linq;
public class UpgradesManagement : MonoBehaviour
{

 


    public TextMeshProUGUI coinstext;

    public TextMeshProUGUI healthCosttext;
    public TextMeshProUGUI flightCosttext;
    public TextMeshProUGUI sizeCosttext;
    public TextMeshProUGUI velocityCosttext;


    public Sprite[] upgradeBars; //array to store the different levels of the upgrade bar
    public Image healthupgradeBar; //image component that specifically stores the health upgrade bar; dragged in from the inspector
    public Image flightupgradeBar;
    public Image sizeupgradeBar;
    public Image velocityupgradeBar;

    //stores position of level in the array

    public Coins coins; //allows upgrades to access the Coins scriptable object
    public HealthUpgrade health; //creates instance of healthUpgrade scriptable object
    public FlightUpgrade flight;
    public SizeUpgrade size;
    public VelocityUpgrade velocity;



    // Start is called before the first frame update
    void Start()
    {
        UpdateUI(); //applies UI elements at start of scene
    }

    

   

    public void UpdateUI() //function to apply UI elements
    {
        coinstext.text = "Coins: " + Mathf.FloorToInt(coins.coinbalance).ToString();
        healthCosttext.text = "Cost: " + Mathf.FloorToInt(health.UpgradeCost).ToString();
        flightCosttext.text = "Cost: " + Mathf.FloorToInt(flight.UpgradeCost).ToString();
        sizeCosttext.text = "Cost: " + Mathf.FloorToInt(size.UpgradeCost).ToString();
        velocityCosttext.text = "Cost: " + Mathf.FloorToInt(velocity.UpgradeCost).ToString();

        healthupgradeBar.sprite = upgradeBars[health.UpgradeLevel];
        flightupgradeBar.sprite = upgradeBars[flight.UpgradeLevel];
        sizeupgradeBar.sprite = upgradeBars[size.UpgradeLevel];
        velocityupgradeBar.sprite = upgradeBars[velocity.UpgradeLevel];
    }
    public void upgradeHealth() //function to upgradehealth
    {
        if (health.UpgradeLevel < upgradeBars.Length-1 && coins.coinbalance >= (health.UpgradeCost)) //if max level (5) isn't reached and coin balance >= cost
        {
            
            healthupgradeBar.sprite = upgradeBars[health.UpgradeLevel];
            health.UpgradeLevel += 1;//increments through upgrade levels


            coins.coinbalance -= Mathf.FloorToInt(health.UpgradeCost); //takes away upgrade cost from amount of coins
            
            coinstext.text = "Coins: " + coins.coinbalance.ToString(); //changes coin text to display coin total after upgrade purchase


            health.UpgradeCost = Mathf.FloorToInt(health.UpgradeCost * 1.5f);
            healthCosttext.text = "Cost: " + health.UpgradeCost.ToString();
            Debug.Log(coins.coinbalance);
            UpdateUI();
        }
        else //if max level (5) is reached 
        {
            Debug.Log("max level");
            return; //exits the function
        }
    }


    public void upgradeFlight() //function to upgradehealth
    {
        if (flight.UpgradeLevel < upgradeBars.Length - 1 && coins.coinbalance >= (flight.UpgradeCost)) //if max level (5) isn't reached and coin balance >= cost
        {

            flightupgradeBar.sprite = upgradeBars[flight.UpgradeLevel]; //
            flight.UpgradeLevel += 1;
            //increments through upgrade levels

            coins.coinbalance -= Mathf.FloorToInt(flight.UpgradeCost); //takes away upgrade cost from amount of coins
            coinstext.text = "Coins: " + coins.coinbalance.ToString(); //changes coin text to display coin total after upgrade purchase


            flight.UpgradeCost = Mathf.FloorToInt(flight.UpgradeCost * 1.5f);
            flightCosttext.text = "Cost: " + flight.UpgradeCost.ToString();
            Debug.Log(coins.coinbalance);
            UpdateUI();
        }
        else //if max level (5) is reached 
        {
            Debug.Log("max level");
            return; //exits the function
        }
    }

    public void upgradeSize() //function to upgradehealth
    {
        if (size.UpgradeLevel < upgradeBars.Length - 1 && coins.coinbalance >= (size.UpgradeCost)) //if max level (5) isn't reached and coin balance >= cost
        {

            sizeupgradeBar.sprite = upgradeBars[size.UpgradeLevel]; //
            size.UpgradeLevel += 1;
            //increments through upgrade levels

            coins.coinbalance -= Mathf.FloorToInt(size.UpgradeCost); //takes away upgrade cost from amount of coins
            coinstext.text = "Coins: " + coins.coinbalance.ToString(); //changes coin text to display coin total after upgrade purchase


            size.UpgradeCost = Mathf.FloorToInt(size.UpgradeCost * 1.5f);
            sizeCosttext.text = "Cost: " + size.UpgradeCost.ToString();
            Debug.Log(coins.coinbalance);
            UpdateUI();
        }
        else //if max level (5) is reached 
        {
            Debug.Log("max level");
            return; //exits the function
        }
    }

    public void upgradeVelocity() //function to upgradehealth
    {
        if (velocity.UpgradeLevel < upgradeBars.Length - 1 && coins.coinbalance >= (velocity.UpgradeCost)) //if max level (5) isn't reached and coin balance >= cost
        {

            velocityupgradeBar.sprite = upgradeBars[velocity.UpgradeLevel]; //
            velocity.UpgradeLevel += 1;
            //increments through upgrade levels

            coins.coinbalance -= Mathf.FloorToInt(velocity.UpgradeCost); //takes away upgrade cost from amount of coins
            coinstext.text = "Coins: " + coins.coinbalance.ToString(); //changes coin text to display coin total after upgrade purchase


            velocity.UpgradeCost = Mathf.FloorToInt(velocity.UpgradeCost * 1.5f);
            velocityCosttext.text = "Cost: " + velocity.UpgradeCost.ToString();
            Debug.Log(coins.coinbalance);
            UpdateUI();
        }
        else //if max level (5) is reached 
        {
            Debug.Log("max level");
            return; //exits the function
        }
    }
}
