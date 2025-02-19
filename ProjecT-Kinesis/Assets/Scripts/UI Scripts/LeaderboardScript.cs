using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;

public class LeaderboardScript : MonoBehaviour
{
    public GameObject entryTemplate; //LeaderboardEntryTemplate from inspector
    public Transform entryContainer; //LeaderboardPanel from inspector

    private void Start()
    {
        DisplayLeaderBoard();
    }

    public void SaveScore(string playerName, int newScore)
    {
        List<int> scores = LoadScores();
        List<string> names = LoadNames();

        scores.Add(newScore);
        names.Add(playerName);

        for (int i = 0; i < scores.Count - 1; i++)
        {
            for (int j = i + 1; j < scores.Count; j++)
            {
                if (scores[j] > scores[i]) // Swap if new score is higher
                {
                    (scores[i], scores[j]) = (scores[j], scores[i]);
                    (names[i], names[j]) = (names[j], names[i]);
                }
            }
        }

        if (scores.Count > 10)
        {
            scores.RemoveAt(10);
            names.RemoveAt(10);
        }

        for (int i = 0; i < scores.Count; i++)
        {
            PlayerPrefs.SetInt("Score" + i, scores[i]);
            PlayerPrefs.SetString("Name" + i, names[i]);
        }

        PlayerPrefs.Save();
    }

    public void DisplayLeaderBoard()
    {
        List<int> scores = LoadScores();
        List<string> names = LoadNames();

        foreach (Transform child in entryContainer)
        {
            if (child != entryTemplate.transform)
            {
                Destroy(child.gameObject);
            }
        }

        for (int i = 0; i < scores.Count; i++)
        {
            GameObject entry = Instantiate(entryTemplate, entryContainer);
            entry.SetActive(true);

            TMP_Text textComponent = entry.GetComponent<TMP_Text>();
            textComponent.text = $"{i + 1}.{names[i]} - {scores[i]}";
        }

    }

    private List<int> LoadScores()
    {
        List<int> scores = new List<int>();
        for(int i = 0; i < 10; i++)
        {
            scores.Add(PlayerPrefs.GetInt("score" +1,0));
        }
        return scores;
    }

    private List<string> LoadNames()
    {
        List<string> names = new List<string>();
        for(int i = 0; i < 10; i++)
        {
            names.Add(PlayerPrefs.GetString("Name" + 1, "Player"));
        }
        return names;
    }
}
