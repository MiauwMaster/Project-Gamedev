using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour {

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
