using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    public void OverScreen(float score, float highscore)
    {
        gameObject.SetActive(true);
        scoreText.text = "Score: " + score.ToString();
        hiScoreText.text = "HighScore: " + highscore.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreManager.scoreCount = 0;
        Debug.Log("GameOverrr");
    }

    public void ReturnMenuButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
