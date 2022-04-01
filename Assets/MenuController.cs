﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("1-1");
    }
}
