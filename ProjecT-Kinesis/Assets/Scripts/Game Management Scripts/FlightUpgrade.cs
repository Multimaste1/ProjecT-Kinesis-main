using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FlightUpgrade", menuName = "FlightUpgrade")]
public class FlightUpgrade : ScriptableObject
{
    public string UpgradeType;
    public float UpgradeCost;
    public int UpgradeLevel = 0;
}
