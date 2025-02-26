using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Highscore", fileName ="Highscore")]
public class Highscore : ScriptableObject
{
    public int highscoreCount = 0;


    public void SaveData()
    {
        PlayerPrefs.SetInt("Highscore", highscoreCount);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highscoreCount = PlayerPrefs.GetInt("Highscore");
        }
    }
}
