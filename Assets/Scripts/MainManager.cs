using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static MainManager Instance;
    public Color TeamColor; // new variable declared

    private void Awake()
    {
         // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;

            LoadColor();
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
        MainManager.Instance.TeamColor = color;
    }
    public void SaveColor()
    {
        SaveData data = new SaveData();
        data.TeamColor = TeamColor;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadColor()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            TeamColor = data.TeamColor;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
    }
}

