﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{ 
    public void ChangeScene(string name)
    {
        if(name == "Start" || name == "Game")
        {
            GameStates.mood = GameStates.maximumMood; 
        }
        SceneManager.LoadScene(name);
    }
    public void ApplicationExit()
    {
        Application.Quit();
    }
}