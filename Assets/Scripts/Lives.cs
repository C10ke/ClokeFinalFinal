using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Dropdown livesDrop;
    public static int liveSelected; // = 0;
    public Text PlayerLives;


    public void DropCboice()
    {
        switch (livesDrop.value)
        {
            case 1:
                PlayerPrefs.SetInt("Lives", 3);
                liveSelected = PlayerPrefs.GetInt("Lives", 3);
                Debug.Log("3 lives");
                break;
            case 2:

                PlayerPrefs.SetInt("Lives", 5);
                liveSelected = PlayerPrefs.GetInt("Lives", 5);
                Debug.Log("5 lives");
                break;
            case 3:

                PlayerPrefs.SetInt("Lives", 9);
                liveSelected = PlayerPrefs.GetInt("Lives", 9);
                Debug.Log("9 lives");
                break;
            default:
                PlayerPrefs.SetInt("Lives", 9);
                liveSelected = PlayerPrefs.GetInt("Lives", 9);
                break;
        }
    }
    void Start()
    {
        PlayerLives.text = PlayerPrefs.GetInt("Lives").ToString();
    }
    public void AddLives()
    {
        liveSelected = PlayerPrefs.GetInt("Lives");
        liveSelected += 1;
        PlayerLives.text = liveSelected.ToString();


        Debug.Log("1up");

    }

    public void SubLives()
    {
        liveSelected -= 1;
        PlayerLives.text = liveSelected.ToString();
        Debug.Log("ouch!");

    }


    void Update()
    {

    }
}
