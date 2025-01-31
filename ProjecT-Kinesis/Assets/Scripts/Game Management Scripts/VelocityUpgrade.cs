using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VelocityUpgrade", menuName = "VelocityUpgrade")]
public class VelocityUpgrade : ScriptableObject
{
    public string UpgradeType;
    public float UpgradeCost;
    public int UpgradeLevel = 0;
}
