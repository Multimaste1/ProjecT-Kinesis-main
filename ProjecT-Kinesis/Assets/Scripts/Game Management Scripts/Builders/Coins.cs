using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Coins", menuName = "Coins")]
public class Coins : ScriptableObject
{
    public new string name;
    public int coinbalance;

    public void SaveData()
    {
        PlayerPrefs.SetInt("Coins", coinbalance); 
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            coinbalance = PlayerPrefs.GetInt("Coins");
        }

    }
}
