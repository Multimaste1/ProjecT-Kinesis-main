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
}
