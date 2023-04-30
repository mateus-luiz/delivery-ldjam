using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("UI Component")]
    [SerializeField] private TextMeshProUGUI scoreText;

    [Header("Score Settings")]
    [SerializeField] private int actualScore = 0;
    [SerializeField] private int scoreMultiplier = 0;

    [Header("Timer Settings")]
    [SerializeField] private Timer timer;
    private bool scored = false;
    [SerializeField] private float currentTime = 0f;
    [SerializeField] private float timeLimit = 8f;

    void Start() 
    {
        timer = FindFirstObjectByType<Timer>();
    }
    void Update()
    {
        if(scored && currentTime <= timeLimit)
        {
            currentTime += Time.deltaTime;
        }

        if(currentTime > 0f && currentTime <= 4f) scoreMultiplier = 1;
        if(currentTime > 4f && currentTime <= 8f) scoreMultiplier = 2;
        if(currentTime > 8f)
        {
            scoreMultiplier = 0;
            scored = false;
            currentTime = 0f;
        }

        scoreText.text = actualScore.ToString();
    }

    public void IncreaseScore()
    {
        switch(scoreMultiplier)
        {
            case 1:
                actualScore += 100;
                break;
            case 2:
                actualScore += 75;
                break;
            default:
                actualScore += 50;
                break;
        }

        currentTime = 0f;
        scored = true;
    }
}
