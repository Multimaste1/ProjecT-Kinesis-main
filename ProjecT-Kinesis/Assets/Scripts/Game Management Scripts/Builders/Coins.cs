using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using System.Reflection;


[CreateAssetMenu(fileName = "Coins", menuName = "Coins")]
public class Coins : ScriptableObject
{
    public new string name;
    public int coinbalance;

    public void SaveData()
    {
        PlayerPrefs.SetInt("Coins", coinbalance);
        PlayerPrefs.SetFloat("Coins", coinbalance);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("VelocityUpgradeLevel"))
        {
            coinbalance = PlayerPrefs.GetInt("Coins");
            
        }

    }
}
