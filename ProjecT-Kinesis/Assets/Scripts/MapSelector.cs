using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public Image backgroundImage; //assigned in the inspector
    public Sprite[] maps; //creates an array to store maps

    public void selectMap(int mapIndex)
    {
        backgroundImage.sprite = maps[mapIndex];
    }


}
