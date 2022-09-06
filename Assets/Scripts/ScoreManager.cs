using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score=0;
    private int highScore;
    public Text scoreText;
    public Text highScoreText;
    public static ScoreManager instance;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        PlayerPrefs.GetInt("highScore");
        highScoreText.text = highScore.ToString();
    }
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        if(highScore>score)
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
            highScoreText.text = highScore.ToString();
        }
    }
    
}
