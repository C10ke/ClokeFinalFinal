using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public Text timeLimitText;
    public Text remainingTimeText;

    public float timelimit = 5.0f;
    public float timeRemaining;
    public float time;

    public Dropdown TimerDropDown;

    public void SetTime(float newTime)
    {
        time = newTime;
        PlayerPrefs.SetFloat("TIMER", time);
    }
       
    void Start()
    {

        timeRemaining = PlayerPrefs.GetFloat("TIMER"); //timelimit;

        timeLimitText.text = "Time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
    }
            
    void Update()
    {



        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            SceneManager.LoadScene("3Exit");
        }

    }
}