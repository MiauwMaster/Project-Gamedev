using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuSript : MonoBehaviour {

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
