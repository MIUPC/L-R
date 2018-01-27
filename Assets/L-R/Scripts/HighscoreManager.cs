using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreManager : MonoBehaviour
{
    public bool saveGame;
    public bool loadGame;
    public bool resetPlayerData;
    public static int highScore;
    public static int playerScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject playerObject;
    Vector3 startingPoint;
    string saveFilePath;
    string saveFileName = "playerSaveData.lrd";

    // Use this for initialization
    void Start()
    {
        saveFilePath = Application.persistentDataPath;

        startingPoint = playerObject.transform.position;
        Debug.Log("starting point: " + startingPoint);
        LoadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (!DidHitObstacle.isDead)
        {
            playerScore = Mathf.RoundToInt(Vector3.Distance(startingPoint, playerObject.transform.position));
            scoreText.text = "Score: " + playerScore.ToString();
            highScoreText.text = "Highscore: " + highScore.ToString();
            //Debug.Log("Distance: " + highScore);
        }
        if (saveGame)
        {
            saveGame = false;
            SaveHighScore();
        }
        if (loadGame)
        {
            loadGame = false;
            LoadHighScore();
        }
        if (resetPlayerData)
        {
            resetPlayerData = false;
            ResetPlayerData();
        }
        if (playerScore > highScore)
        {
            highScore = Mathf.RoundToInt(playerScore);
        }
    }

    public void SaveHighScore()
    {
        PlayerData playerData = new PlayerData();

        playerData.highScore = highScore;

        string rawJSON = JsonUtility.ToJson(playerData);

        Debug.Log(Path.Combine(saveFilePath, saveFileName));
        File.WriteAllText(Path.Combine(saveFilePath, saveFileName), rawJSON);
    }

    void LoadHighScore()
    {
        //new PlayerData();
        if (File.Exists(Path.Combine(saveFilePath, saveFileName)))
        {
            string rawJSON = File.ReadAllText(Path.Combine(saveFilePath, saveFileName));
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(rawJSON);

            highScore = playerData.highScore;
            Debug.Log(highScore);
        }
    }

    void ResetPlayerData()
    {
        if(File.Exists(Path.Combine(saveFilePath, saveFileName)))
            File.Delete(Path.Combine(saveFilePath, saveFileName));
    }
}

public class PlayerData
{
    public int highScore;
}
