using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fuelscript_p2 : MonoBehaviour
{

    public float fuelcount;
    public float fuelusage;
    // Use this for initialization
    void Start()
    {

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

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 20), "Fuel: " + fuelcount);

    }


}
