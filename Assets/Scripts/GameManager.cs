using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public void QuitBtn()
    {
        Application.Quit();
    }
    public void NextBtn()
    {
        SceneManager.LoadScene("2game");
    }

    public void DoneBtn()
    {
        SceneManager.LoadScene("3Exit");
    }

}
