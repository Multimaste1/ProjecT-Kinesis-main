using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="skinData",menuName ="skinData")]
public class SelectedSkinData : ScriptableObject
{
    public int selectedSkinindex;

    public void SaveData()
    {
        PlayerPrefs.SetInt("skinIndex", selectedSkinindex);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("skinIndex"))
        {
            selectedSkinindex = PlayerPrefs.GetInt("skinIndex");
        }
    }
}
