using UnityEngine;
using System.Collections;

public class SpeedBooster : MonoBehaviour {

    float originalpowerp1;
    float originalpowerp2;
    public int boostFactor;
    public int boostDuration;


	void OnTriggerEnter2D(Collider2D other)
    {  
        if (other.gameObject.tag == "player1")
        {
            StartCoroutine(Boostp1());
        }

        if (other.gameObject.tag == "player2")
        {
            StartCoroutine(Boostp2());
        }
    }

    IEnumerator Boostp1()
    {
        originalpowerp1 = Movementscript.power;
        Movementscript.power *= boostFactor;
        yield return new WaitForSeconds(boostDuration);
        Movementscript.power = originalpowerp1;
    }

    IEnumerator Boostp2()
    {
        originalpowerp2 = Movementscript_p2.power;
        Movementscript_p2.power *= boostFactor;
        yield return new WaitForSeconds(boostDuration);
        Movementscript_p2.power = originalpowerp2;
    }
}
