using UnityEngine;
using System.Collections;

public class pitstop : MonoBehaviour {

    public float refillAmount;
    public int p1Pitstop;
    public int p2Pitstop;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            Movementscript.friction = 20;
            p1Pitstop += 1;
        }

        if (other.gameObject.tag == "player2")
        {
            Movementscript_p2.friction = 20;
            p2Pitstop += 1;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            Fuelscript_p1.fuelcount += refillAmount * Time.deltaTime;
        }

        if (other.gameObject.tag == "player2")
        {
            Fuelscript_p2.fuelcount += refillAmount * Time.deltaTime;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            Movementscript.friction = 2;
        }

        if (other.gameObject.tag == "player2")
        {
            Movementscript_p2.friction = 2;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 25, 150, 20), "Pitstops: " + p1Pitstop);
        GUI.Label(new Rect(Screen.width - 100, 25, 100, 50), "Pitstops: " + p2Pitstop);

    }
}
