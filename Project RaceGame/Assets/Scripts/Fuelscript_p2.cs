using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fuelscript_p2 : MonoBehaviour
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

        if (Input.GetKey(KeyCode.UpArrow))
        {
            fuelcount = fuelcount - fuelusage * Time.deltaTime;
        }

        if (fuelcount <= 0)
        {
            Movementscript_p2.power = 0;
            fuelcount = 0;
        }

        if (fuelcount > fuelamount)
        {
            fuelcount = fuelamount;
        }

    }
}