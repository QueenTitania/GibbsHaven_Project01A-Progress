﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
            SceneManager.LoadScene("Sandbox");
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

}
