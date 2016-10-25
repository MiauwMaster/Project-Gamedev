using UnityEngine;
using System.Collections;

public class Movementscript_p2 : MonoBehaviour
{


<<<<<<< HEAD:Project RaceGame/Assets/Scripts/Movementscript_p2.cs
<<<<<<< HEAD:Project RaceGame/Assets/Scripts/Movementscript_p2.cs
    public static float power = 60;
    public float maxspeed = 80;
    public float turnpower = 2.5f;
=======
    public float power = 60;
    public float maxspeed = 80;
    public float turnpower = 2;
>>>>>>> origin/master:Project RaceGame/Assets/Scripts/Movementscript_p2.cs
    public float friction = 2;
=======
    public float power = 3;
    public float maxspeed = 5;
    public float turnpower = 2;
    public float friction = 3;
>>>>>>> parent of 37c6127... Versie 0.2.4:Project RaceGame/Assets/Scripts/Movementscript p2.cs
    public Vector2 curspeed;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        curspeed = new Vector2(rb.velocity.x, rb.velocity.y);

        if (curspeed.magnitude > maxspeed)
        {
            curspeed = curspeed.normalized;
            curspeed *= maxspeed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * power);
            rb.drag = friction;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-(transform.up) * (power / 2));
            rb.drag = friction;
        }

        if (rb.drag == friction)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward * turnpower);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.forward * -turnpower);
            }
        }
        noGas();

    }

    void noGas()
    {
        bool gas;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            gas = true;
        }
        else
        {
            gas = false;
        }

        if (!gas)
        {
            rb.drag = friction * 2;
        }
    }
}