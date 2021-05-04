using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int highScores;
    public int currentPoints;
    public int liveSelected;

    public PlayerData(Score score)
    {
        currentPoints = Score.currentPoints;
        liveSelected = Lives.liveSelected;

    }
}
