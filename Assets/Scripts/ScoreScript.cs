using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;

    public Text scoreText;
    public Text gameOverScoreText;
    public Text highScoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString();
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highScoreText.text = "HIGHSCORE: " + highscore.ToString();
        
    }

    void Update()
    {
        gameOverScoreText.text = "Score: " + score.ToString();
    }

    
   public void AddPointMercury()
    {
        score += 5;
        scoreText.text = score.ToString();
        if(highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

    }

    public void AddPointMars()
    {
        score += 10;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void AddPointVenus()
    {
        score += 20;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void AddPointEarth()
    {
        score += 20;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

    }

    public void AddPointNeptune()
    {
        score += 30;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void AddPointUranus()
    {
        score += 40;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

    }

    public void AddPointSaturn()
    {
        score += 70;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void AddPointJupiter()
    {
        score += 100;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
