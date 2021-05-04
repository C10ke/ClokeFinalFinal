using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int currentPoints;

    public Text text;
    public Text hightScore;
    public Text gameOverScore;

    void Start()
    {
        currentPoints = 0;
        hightScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        gameOverScore.text = PlayerPrefs.GetInt("GAMEOVERSCORE", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = currentPoints.ToString();
        PlayerPrefs.SetInt("GAMEOVERSCORE", currentPoints);



        if (currentPoints > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", currentPoints);
            hightScore.text = currentPoints.ToString();
        }


    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        hightScore.text = "0";

    }

    public void SaveGame()
    {
        Save.SavePlayer(this);
        Debug.Log("Game Saved!");

    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.currentPoints = currentPoints;


        return save;
    }


    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void LoadGame()
    {

        PlayerData data = Save.LoadPlayer();

        currentPoints = data.currentPoints;
        Debug.Log("Game loaded");
    }
}