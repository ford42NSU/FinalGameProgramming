using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainMenu;
using UnityEngine.UI;
using System;

public class nameInGame : MonoBehaviour
{
    public Text nameLabel;
    public Text livesLabel;
    public Text timerLabel;
    // Start is called before the first frame update
    void Start()
    {
        nameLabel.text = "currently playing: " + userName;
        livesLabel.text = lives.ToString();
        timerLabel.text = timerBonus.ToString();
    }
    void Update()
    {
        timerBonus = timerBonus - Time.deltaTime;
        timerBonus = Math.Round(timerBonus, 2);
        if (timerBonus <= 0)
        {
            timerLabel.text = "0 (seconds) left";
        }
        else
        {
            timerLabel.text = timerBonus.ToString() + " (seconds) left";
        }
        livesLabel.text = lives.ToString();
        
    }

    public void increaseLives()
    {
        lives++;
    }

    public void decreaseLives()
    {
        lives--;
    }
}
