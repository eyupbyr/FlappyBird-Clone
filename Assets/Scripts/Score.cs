using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText = default;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Game_Manager.PipesPassedByBird.ToString();
    }
}
