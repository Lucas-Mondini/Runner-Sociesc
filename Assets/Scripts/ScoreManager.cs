using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text highscoreText;

    private int score = 0;
    private int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE = " + score.ToString();
        highscoreText.text = "HIGHSCORE = " + highscore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPoint()
    {
        score += 1;
        scoreText.text = "SCORE = " + score.ToString();
        if (score > highscore)
        {
            highscore = score;
            highscoreText.text = "HIGHSCORE = " + highscore.ToString();
            PlayerPrefs.SetInt("highscore", highscore);
        }
    }
}
