﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public Transform canvas;
    public Transform pauseMenu;
    public Transform settingsMenu;

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
        public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            if (pauseMenu.gameObject.activeInHierarchy == false)
            {
                pauseMenu.gameObject.SetActive(true);
                settingsMenu.gameObject.SetActive(false);

            }
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
        public void Settings(bool Open)
    {
        if (Open)
        {
            settingsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!Open)
        {
            settingsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);

        }
    }
	
}
