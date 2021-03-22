using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    private static GameObject bird;
    private static float pipesPassedByBird = 0f;

    [SerializeField] GameObject gameOverImage = default;
    [SerializeField] Text scoreText = default;
    [SerializeField] Text yourScoreText = default;
    [SerializeField] Text highScoreText = default;

    void Start()
    {
        bird = GameObject.Find("Bird");
    }

    public static float PipesPassedByBird
    {
        get { return pipesPassedByBird; }
        set { pipesPassedByBird = value; }
    }
    
    public static GameObject Bird
    {
        get { return bird; }
    }

    public void EndGame()
    {
        yourScoreText.text = scoreText.text;

        if (int.Parse(yourScoreText.text) > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", int.Parse(scoreText.text));
            highScoreText.text = "New Highscore";
        }
        else highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();

        gameOverImage.SetActive(true);

        Time.timeScale = 0;

        pipesPassedByBird = 0;
    }
}
