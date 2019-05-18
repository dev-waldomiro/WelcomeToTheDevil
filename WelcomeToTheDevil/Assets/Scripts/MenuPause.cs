﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
public class MenuPause : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;

    }
    public void LoadScene()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
