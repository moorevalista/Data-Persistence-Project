using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class UIMainScene : MonoBehaviour
{
    public static UIMainScene Instance;
    public string newPlayerName;
    public string PlayerName;
    public int Score;

    private void Awake() {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(UIMainScene.Instance.PlayerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]

    class DataScore
    {
        public string PlayerName;
        public int Score;
    }

    public void SaveScore() {
        DataScore data = new DataScore();
        data.PlayerName = newPlayerName;
        data.Score = Score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore() {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path)) {
            string json = File.ReadAllText(path);
            DataScore data = JsonUtility.FromJson<DataScore>(json);

            PlayerName = data.PlayerName;
            Score = data.Score;
        }
    }
}
