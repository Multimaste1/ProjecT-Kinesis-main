using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighscoreUI : MonoBehaviour
{

    public Highscore highscore;
    public Score score;
    public TextMeshProUGUI highScoretext;
    public TextMeshProUGUI yourScoretext;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
       highscore.LoadData();
       highScoretext.text = "Highscore: " + highscore.highscoreCount.ToString();
       yourScoretext.text = "Your Score: " + score.score.ToString();
        highscore.SaveData();

    }

    public void checkScore(Score score, Highscore highscore)
    {
        highscore.LoadData();
        if (score.score > highscore.highscoreCount)
        {
            highscore.highscoreCount = score.score;
            highscore.SaveData();
            highScoretext.text = "New Highscore: " + highscore.highscoreCount.ToString();
            return;
        }
        else 
        {
            return;
        }
        
    }
}
