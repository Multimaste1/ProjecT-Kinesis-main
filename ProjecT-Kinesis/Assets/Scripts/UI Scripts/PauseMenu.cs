using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //bool variable for whether game is paused or not; carries between scripts
    public GameObject pauseMenuUI; //stores PauseMenu Canvas
   
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //when escape key is pressed
        {
            if (GameIsPaused) //if GameIsPaused = true
            {
                Resume(); //when escape key is pressed game is resumed
            }
            else
            {
                Pause(); //when escape key is pressed game is paused
            }
        }
    }
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false); //disables pause menu
        Time.timeScale = 1f; //time in game is paused
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); //enables pause menu
        Time.timeScale= 0f; //time in game is no longer paused
        GameIsPaused = true;
    }
}
