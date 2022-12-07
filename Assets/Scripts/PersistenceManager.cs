using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{
    public static PersistenceManager Instance;

    public string playerName;
    public int score;
    public BestScore currentBestScore;

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadBestScore();
    }    

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/best_score.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            currentBestScore = JsonUtility.FromJson<BestScore>(json);
        }
        else
        {
            currentBestScore = new BestScore();
        }
    }

    public void SaveBestScore(int points)
    {
        if (points > currentBestScore.score)
        {
            currentBestScore.score = points;
            currentBestScore.playerName = playerName;

            string json = JsonUtility.ToJson(currentBestScore);
            File.WriteAllText(Application.persistentDataPath + "/best_score.json", json);
        }        
    }

    [Serializable]
    public class BestScore
    {   
        public string playerName = "Unknown Player";
        public int score = 0;        
    }
}
