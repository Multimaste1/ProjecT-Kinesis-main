using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public SelectedSkinData skinData; //dragged in from the inspector
    public List<Sprite> skins; //dragged in from the inspector
    public GameObject player;
    private Sprite playerSprite;

    void Start()
    {
        skinData.LoadData();
        player.GetComponent<SpriteRenderer>().sprite = skins[skinData.selectedSkinindex]; // Apply the saved skin
    }

    
 
}
