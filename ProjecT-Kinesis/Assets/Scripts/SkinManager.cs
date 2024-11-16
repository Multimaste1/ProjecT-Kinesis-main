using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinManager : MonoBehaviour
{
   public SpriteRenderer spriteRenderer;
   public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerskin;
    

    public void nextSkin()
    {
        selectedSkin += 1;
            if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
            spriteRenderer.sprite = skins[selectedSkin];
    }

    public void previousSkin()
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin <0)
        {
            selectedSkin = skins.Count-1;
        }
        spriteRenderer.sprite = skins[selectedSkin];
    }

    public void PlayGame(string sceneName)
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Graphics/Sprites/Prefabs/Selectedskin.prefab");
        SceneManager.LoadScene(sceneName);
    }
  
    
}
