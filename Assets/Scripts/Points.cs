using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text pointTxt;
    public int currentPoints;

    void Start()
    {
        currentPoints = 0;
        
    }

    void Update()
    {
        pointTxt.text = currentPoints.ToString();
    }

    public void AddPoints()
    {
        currentPoints += 1;
    }

    public void SubPoints()
    {
        currentPoints -= 1;
    }
}
