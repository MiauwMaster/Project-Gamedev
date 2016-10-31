using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class winnercheck : MonoBehaviour {



    void OnTriggerEnter2D(Collider2D other)
        {
            if ((other.gameObject.tag == "player1") && (lapcounterp1.p1win == true))
            {
             SceneManager.LoadScene(3);
            }
    
         if ((other.gameObject.tag == "player2") && (lapcounterp2.p2win == true))
            {
             SceneManager.LoadScene(3);
            }
        }
}
