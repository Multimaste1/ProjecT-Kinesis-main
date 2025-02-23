using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FlightUpgrade", menuName = "FlightUpgrade")]
public class FlightUpgrade : ScriptableObject
{
    public string UpgradeType;
    public float UpgradeCost;
    public int UpgradeLevel = 0;

    public void SaveData()
    {
        PlayerPrefs.SetInt("FlightUpgradeLevel", UpgradeLevel);
        PlayerPrefs.SetFloat("FlightUpgradeCost", UpgradeCost);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("FlightUpgradeLevel"))
        {
            UpgradeLevel = PlayerPrefs.GetInt("FlightUpgradeLevel");
            UpgradeCost = PlayerPrefs.GetFloat("FlightUpgradeCost");
        }

    }
}
