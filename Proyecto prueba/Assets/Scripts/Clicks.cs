using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicks : MonoBehaviour
{
    public Text totalClicks;

    public int numberOfClicks;

    public GameObject startPanel, gamePanel, endPanel;

    public float playTime;
    public float timeLeft;
    public Text timeLeftToPlay;

    private bool timeIsTicking = false;

    public void addClicks()
    {
        numberOfClicks++;

        totalClicks.text = numberOfClicks.ToString();
    }

    private void Start()
    {
    }

    public void restart()
    {
        numberOfClicks = 0;
        totalClicks.text = numberOfClicks.ToString();

        endPanel.SetActive(false);
        startPanel.SetActive(true);
    }

    public void startCountdown()
    {
        timeLeft = playTime;
        timeIsTicking = true;
    }

    private void Update()
    {
        if (timeIsTicking)
        {
            timeLeft -= Time.deltaTime;

            if (timeLeft < 0)
            {
                timeIsTicking = false;
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
    }
}