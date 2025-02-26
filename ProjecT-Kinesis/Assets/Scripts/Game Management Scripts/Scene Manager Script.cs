using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SceneManagerScript : MonoBehaviour
{
    public string sceneName;

    // Method to set the scene name (for map selection)
    public void SetSceneName(string name)
    {
        sceneName = name;
    }

    //method for loading maps 
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    //method for loading menus
    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
