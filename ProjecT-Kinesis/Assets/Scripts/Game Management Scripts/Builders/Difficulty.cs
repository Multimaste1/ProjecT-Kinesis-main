using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Difficulty", menuName = "Difficulty")]
public class Difficulty : ScriptableObject
{
    public int difficulty; //stores difficulty level

    public void SaveData()
    {
        PlayerPrefs.SetInt("Difficulty", difficulty);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("Difficulty"))
        {
            difficulty = PlayerPrefs.GetInt("Difficulty");
        }
    }
}
