using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Selectedskin;
    public GameObject Player;

    private Sprite playerSprite;
    void Start()
    {
        playerSprite = Selectedskin.GetComponent<SpriteRenderer>().sprite;
        Player.GetComponent<SpriteRenderer>().sprite = playerSprite;
    }

    // Update is called once per frame
 
}
