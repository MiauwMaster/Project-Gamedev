﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuSript : MonoBehaviour {

    public Transform mainMenu, optionsMenu;

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OptionsMenu(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }
}
