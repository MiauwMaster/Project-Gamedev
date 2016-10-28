using UnityEngine;
using System.Collections;

public class pitstop : MonoBehaviour {

    public float refillAmount;
    public static int p1Pitstop;
    public static int p2Pitstop;

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
}
