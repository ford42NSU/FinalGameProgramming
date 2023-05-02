using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static double timerBonus = 0;
    public static string userName = "Player";
    public static int lives = 9;
    public Dropdown livesUI;
    public Slider timerUI;
    public InputField nameUI;

    void Start()
    {
        timerBonus = 0;
        userName = "Player";
        lives = 9;
    }
    // Update is called once per frame
    void Update()
    {
        timerBonus = timerUI.value;
        userName = nameUI.text;
        if (livesUI.value > 0)
        {
            lives = livesUI.value;
        }
        
    }
}
