using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class winnercheck : MonoBehaviour {



    void OnTriggerStay2D(Collider2D other)
        {
            if ((other.gameObject.name == "player1") && (lapcounterp1.p1win == true))
            {
               SceneManager.LoadScene(2);
            }
    
            if ((other.gameObject.name == "player2") && (lapcounterp2.p2win == true))
            {
                SceneManager.LoadScene(3);
            }
    }
}
