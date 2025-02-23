using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "HealthUpgrade", menuName = "HealthUpgrade")]
public class HealthUpgrade : ScriptableObject
{
   public string UpgradeType;
    public float UpgradeCost;
    public int UpgradeLevel = 0;

    public void SaveData() //function to save current upgrade level and cost
    {
        PlayerPrefs.SetInt("HealthUpgradeLevel", UpgradeLevel); //stores upgrade level and cost values in keys
        PlayerPrefs.SetFloat("HealthUpgradeCost", UpgradeCost);
        PlayerPrefs.Save();
    }

    public void LoadData() //function to load last upgrade level and cost data
    {
        if (PlayerPrefs.HasKey("HealthUpgradeLevel"))
        {
            UpgradeLevel = PlayerPrefs.GetInt("HealthUpgradeLevel");
            UpgradeCost = PlayerPrefs.GetFloat("HealthUpgradeCost");
        }
            
    }
}
