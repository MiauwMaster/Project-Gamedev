using UnityEngine;
using System.Collections;

public class SpeedBooster : MonoBehaviour {

    float originalpower;
    public int boostFactor;
    public int boostDuration;


	void Start () {
        originalpower = Movementscript.power;
	}

    void OnTriggerEnter2D(Collider2D other)
    {  
        if (other.gameObject.tag == "player1")
        {
            StartCoroutine(Boostp1());
        }

        if (other.gameObject.tag == "player1")
        {
            StartCoroutine(Boostp2());
        }
    }

    IEnumerator Boostp1()
    {
        Movementscript.power *= boostFactor;
        yield return new WaitForSeconds(boostDuration);
        Movementscript.power = originalpower;
    }

    IEnumerator Boostp2()
    {
        Movementscript_p2.power *= boostFactor;
        yield return new WaitForSeconds(boostDuration);
        Movementscript_p2.power = originalpower;
    }
}
