using UnityEngine;
using System.Collections;

public class Pepe : MonoBehaviour
{
    public static int pepeCount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            pepeCount += 1;

            Destroy(this.gameObject);

            if (pepeCount > 6)
            {
                Movementscript.power += 10;
            }
        }
    }

}
