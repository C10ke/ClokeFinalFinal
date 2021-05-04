using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Name : MonoBehaviour
{
    public string playerName;
    public GameObject inputField;
    public GameObject textDisplay;
    public Text DisplayPlayerName;


    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text;
        PlayerPrefs.SetString("PLAYERNAME", playerName);
        textDisplay.GetComponent<Text>().text = "Hello " + playerName + ", Click on buttons to make things happen。In game press 'ESC' for menu. Slider for game time.";
        Debug.Log("name inserted");
    }

    void Start()
    {
        DisplayPlayerName.text = PlayerPrefs.GetString("PLAYERNAME", "Person");
    }
}