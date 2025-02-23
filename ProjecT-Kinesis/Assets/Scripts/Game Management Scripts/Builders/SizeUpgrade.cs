using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SizeUpgrade", menuName = "SizeUpgrade")]
public class SizeUpgrade : ScriptableObject
{
    public string UpgradeType;
    public float UpgradeCost;
    public int UpgradeLevel = 0;

    public void SaveData()
    {
        PlayerPrefs.SetInt("SizeUpgradeLevel", UpgradeLevel);
        PlayerPrefs.SetFloat("SizeUpgradeCost", UpgradeCost);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("SizeUpgradeLevel"))
        {
            UpgradeLevel = PlayerPrefs.GetInt("SizeUpgradeLevel");
            UpgradeCost = PlayerPrefs.GetFloat("SizeUpgradeCost");
        }

    }
}
