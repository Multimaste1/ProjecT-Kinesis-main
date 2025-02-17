using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Score score;

    // Start is called before the first frame update
    void Start()
    {
        score.score = 0;
        scoreText.text = "Score: " + score.score.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.score.ToString("0");
    }
}
