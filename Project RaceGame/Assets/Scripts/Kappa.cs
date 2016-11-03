using UnityEngine;
using System.Collections;

public class Kappa : MonoBehaviour
{
    public static int kappaCount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player2")
        {
            kappaCount += 1;
            Destroy(this.gameObject);

            if (kappaCount > 6)
            {
                Movementscript_p2.power += 10;
            }
        }
    }

}
