using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Score score;
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        score.score = 0;
        scoreText.text = "Score: " + score.score.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timerCount % 30 == 0) //score increases after every 30 seconds
        {
            score.score += 20;
        }
        scoreText.text = "Score: " + score.score.ToString("0");
    }
}
