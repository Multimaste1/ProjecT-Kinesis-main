using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public Difficulty Difficulty;
    
    // Start is called before the first frame update
    public void setEasy() //sets difficulty level (1 = easy, 2 = medium, 3 = hard)
    {
        Difficulty.difficulty = 1;
    }

    public void setMedium()
    {
        Difficulty.difficulty = 2;
    }

    public void setHard() 
    {
        Difficulty.difficulty = 3;
    }

}
