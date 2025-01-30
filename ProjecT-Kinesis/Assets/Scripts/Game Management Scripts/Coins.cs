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
}
