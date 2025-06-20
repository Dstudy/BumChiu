using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool gameHasEnd = false;
    public AudioSource die;
    public GameOverScreen GameOverScreen;
    public void EndGame()
    {
        if (gameHasEnd == false)
        {
            die.Play();
            gameHasEnd = true;
            Debug.Log("End Game");
            GameOverScreen.OverScreen(ScoreManager.scoreCount, ScoreManager.hiSoreCount);
        }
    }
    
}
