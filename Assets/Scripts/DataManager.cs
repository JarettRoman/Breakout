using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string playerName;
    public string highestScoringPlayer;
    public int highestScore;

    private void Awake() 
    {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string highestScoringPlayer;
        public int highestScore;
    }

    public void Save(string name, int hi_score)
    {
        SaveData data = new SaveData();
        data.highestScoringPlayer = name;
        data.highestScore = hi_score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highestScoringPlayer = data.highestScoringPlayer;
            highestScore = data.highestScore;
        }
    }


    // public void SaveColor()
    // {
    //     SaveData data = new SaveData();
    //     data.TeamColor = TeamColor;

    //     string json = JsonUtility.ToJson(data);

    //     File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    // }

    // public void LoadColor()
    // {
    //     string path = Application.persistentDataPath + "/savefile.json";
    //     if (File.Exists(path))
    //     {
    //         string json = File.ReadAllText(path);
    //         SaveData data = JsonUtility.FromJson<SaveData>(json);

    //         TeamColor = data.TeamColor;
    //     }
    // }
}
