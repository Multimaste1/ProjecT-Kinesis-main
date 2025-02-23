using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VelocityUpgrade", menuName = "VelocityUpgrade")]
public class VelocityUpgrade : ScriptableObject
{
    public string UpgradeType;
    public float UpgradeCost;
    public int UpgradeLevel = 0;

    public void SaveData()
    {
        PlayerPrefs.SetInt("VelocityUpgradeLevel", UpgradeLevel);
        PlayerPrefs.SetFloat("VelocityUpgradeCost", UpgradeCost);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("VelocityUpgradeLevel"))
        {
            UpgradeLevel = PlayerPrefs.GetInt("VelocityUpgradeLevel");
            UpgradeCost = PlayerPrefs.GetFloat("VelocityUpgradeCost");
        }

    }
}
