using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrades", menuName = "Persistence")]
public class Upgrades : ScriptableObject
{
    public string upgradeName;
    public int baseCost;
    public float costMultiplier;
    public int maxlevel = 5;
    [HideInInspector] public int currentLevel = 0;
   
    public int getUpgradeCost()
    {
        return Mathf.FloorToInt(baseCost*1.5f);
    }

    public bool isMaxLevel()
    {
        return currentLevel >= maxlevel;
    }

    public void LevelUp()
    {
        if (!isMaxLevel())
        {
            currentLevel+=1;
        }
    }
}
