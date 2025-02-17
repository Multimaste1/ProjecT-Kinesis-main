using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public Timer timer;
    public TextMeshProUGUI timerText;

    // Update is called once per frame
    private void Start()
    {
        timer.timerCount = 0;
        timerText.text = "Timer: " + timer.timerCount.ToString("0");
    }
    void Update()
    {
        timer.timerCount += Time.deltaTime;
        timerText.text = "Timer: " + timer.timerCount.ToString("0");
    }
}
