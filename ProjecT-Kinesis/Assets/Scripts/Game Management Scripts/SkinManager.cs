using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinManager : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; //stores the sprite I want to render
   public List<Sprite> skins = new List<Sprite>(); //stores list of sprites added in the inspector
    private int selectedSkin = 0;
    public GameObject playerskin;
    

    public void nextSkin()
    {
        selectedSkin += 1; //iterates through the list of skins as button is clicked
            if (selectedSkin == skins.Count) //condition when end of the list is reached
        {
            selectedSkin = 0; //resets to back to start of the list
        }
            spriteRenderer.sprite = skins[selectedSkin]; //stores the sprite that is to be rendered by "spriteRenderer" taking it from the skins list
    }

    public void previousSkin() 
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin <0)
        {
            selectedSkin = skins.Count-1; //resets count if end of list is reached (from other end)
        }
        spriteRenderer.sprite = skins[selectedSkin];
    }

    public void PlayGame(string sceneName)
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Graphics/Sprites/Prefabs/Selectedskin.prefab"); //saves playerskin as a prefab in the editor
        SceneManager.LoadScene(sceneName); //loads next scene
    }
  
    
}
