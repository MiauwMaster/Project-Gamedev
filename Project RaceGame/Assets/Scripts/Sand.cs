using UnityEngine;
using System.Collections;

public class Sand : MonoBehaviour
{

    public int dragamount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            Movementscript.friction = dragamount;
        }

        if (other.gameObject.tag == "player2")
        {
            Movementscript_p2.friction = dragamount;
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
