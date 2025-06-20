using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    
    public static float scoreCount;
    public static float hiSoreCount;

    private void Start()
    {
        if (PlayerPrefs.HasKey("hiscore"))
        {
            hiSoreCount = PlayerPrefs.GetFloat("hiscore");
        }
    }

    private void Update()
    {
        scoreText.text = "Score: " + scoreCount;
        if (scoreCount > hiSoreCount)
        {
            hiSoreCount = scoreCount;
            PlayerPrefs.SetFloat("hiscore", hiSoreCount);
        }
    }
}
