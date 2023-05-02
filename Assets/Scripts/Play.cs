using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Play : MonoBehaviour
{
    
    public void play()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void restart()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void quit()
    {
        EditorApplication.isPlaying = false;
    }

}
