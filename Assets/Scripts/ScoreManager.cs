using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreUI;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreUI.text = "Score: " + score.ToString();
    }

    public void AddPoint()
    {
        score += 10;
        scoreUI.text = "Score: " + score.ToString();   
    }
}
