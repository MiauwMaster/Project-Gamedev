using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fuelscript_p1 : MonoBehaviour
{

    public static float fuelcount;
    public float fuelamount;
    public float fuelusage;
    // Use this for initialization
    void Start()
    {
        fuelcount = fuelamount;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)))
        {
            fuelcount = fuelcount - fuelusage * Time.deltaTime;
        }

        if (fuelcount <= 0)
        {
            Movementscript.power = 0;
            fuelcount = 0;
        }

    }
}
