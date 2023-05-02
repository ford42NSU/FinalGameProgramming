using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.IO;
using static Points;
using static MainMenu;

public class PuaseController : MonoBehaviour
{

    public GameObject pauseMenu;
    public AudioSource music;
    bool isMuted = false;


    bool isPaused = false;
    int savedPoints;
    double savedTimer;
    int savedLives;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                pauseMenu.SetActive(false);
                isPaused = false;
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.SetActive(true);
                isPaused = true;
                Time.timeScale = 0;
            }
        }
    }

    public void continueGame()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }

    public void saveGame()
    {
        savedPoints = points;
        savedTimer = timerBonus;
        savedLives = lives;
    }

    public void loadGame()
    {
        points = savedPoints;
        timerBonus = savedTimer;
        lives = savedLives;
    }

    public void musicToggle()
    {
        if(isMuted)
        {
            music.volume = 1;
            isMuted = false;
        }
        else
        {
            music.volume = 0;
            isMuted = true;
        }
        
    }

    public void saveToJson()
    {
        saveToJsonStuff preJson = new saveToJsonStuff();
        preJson.timerJson = timerBonus;
        preJson.livesJson = lives;
        preJson.pointsJson = points;

        string test = JsonUtility.ToJson(preJson);
        Debug.Log(test);
    }
}


[Serializable]
public class saveToJsonStuff
{
    public double timerJson;
    public int livesJson;
    public int pointsJson;
}