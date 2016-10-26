using UnityEngine;
using System.Collections;

public class pitstop : MonoBehaviour {

    public float refillAmount;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            Fuelscript_p1.fuelcount += refillAmount;
        }

        if (other.gameObject.tag == "player2")
        {
            Fuelscript_p2.fuelcount = Fuelscript_p2.fuelcount + refillAmount;
        }
    }
}
