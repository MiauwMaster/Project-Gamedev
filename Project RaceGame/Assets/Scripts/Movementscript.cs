﻿using UnityEngine;
using System.Collections;

public class Movementscript : MonoBehaviour
{

    
    public static float power = 60;
    public float maxspeed = 80;
    public float turnpower = 2.5f;
    public static float friction = 2;
    public Vector2 curspeed;
    public Rigidbody2D rb;
    public static int speed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        power = 60;
        friction = 2;
    }


    void FixedUpdate()
    {
        curspeed = new Vector2(rb.velocity.x, rb.velocity.y);
        speed = Mathf.RoundToInt((float)(rb.velocity.magnitude * 3.6));

        if (curspeed.magnitude > maxspeed)
        {
            curspeed = curspeed.normalized;
            curspeed *= maxspeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * power);
            rb.drag = friction;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-(transform.up) * (power / 2));
            rb.drag = friction;
        }

        if (speed > 0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward * turnpower);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.forward * -turnpower);
            }
        }

        

        noGas();

    }

    void noGas()
    {
        bool gas;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
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