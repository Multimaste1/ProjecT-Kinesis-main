using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UpgradesManagement : MonoBehaviour
{

    public Sprite[] levels; //array to store the different levels of tbe upgrade bar
    public Image upgradeBar; //image component that stores the upgrade bar
    public int index = 0; //stores position of level in the array

    public float coins;
    private float cost =10;
    public TextMeshProUGUI coinstext;


    
    // Start is called before the first frame update
    void Start()
    {
        upgradeBar = GetComponent<Image>(); // stores image component of the upgrade bar
        coinstext.text = "Coins:" + coins.ToString();
    }

    // Update is called once per frame

    public void upgrade() //function to update upgrade bar
    {
        if (index < levels.Length && coins>=cost) //if max level isn't reached
        {
            upgradeBar.sprite = levels[index];
            index += 1; //increments through upgrade levels

            coins -= cost; //takes away upgrade cost from amount of coins
            cost = MathF.Floor(cost *1.5f); //increases upgrade cost by 50%
            coinstext.text = "Coins:"+coins.ToString(); //changes coin text to display coin total after upgrade purchase
        }
        else //if max level (5) is reached 
        {
            Debug.Log("max level");
            return; //exits the function
        }
       
    }
    

}
