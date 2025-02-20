using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Selectedskin; //dragged in from the inspector
    public GameObject Player; //dragged in from the inspector

    private Sprite playerSprite;
    void Start()
    {
        playerSprite = Selectedskin.GetComponent<SpriteRenderer>().sprite; //gets sprite component of Selectedskin prefab at start; storing it as a prefab maintains the skin through scenes
        Player.GetComponent<SpriteRenderer>().sprite = playerSprite; //attaches sprite component of Selectedskin prefab to Player prefab
    }

    
 
}
