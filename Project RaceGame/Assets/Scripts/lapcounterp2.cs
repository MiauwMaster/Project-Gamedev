﻿using UnityEngine;
using System.Collections;

public class lapcounterp2 : MonoBehaviour
{

    public GameObject[] checkPointsList;
    public GameObject finish;

    public int checkpointCounter;
    public static int laps;
    public int lapsToWin;
    public static bool p2win = false;

    void Start()
    {
        checkPointsList = GameObject.FindGameObjectsWithTag("CheckPoint");
        finish = GameObject.FindGameObjectWithTag("Finish");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "CheckPoint")
        {
            checkpointCounter += 1;
        }

        if ((other.gameObject.tag == "Finish") && (checkpointCounter == checkPointsList.Length))
        {
            laps += 1;
            checkpointCounter = 0;
        }

        if ((other.gameObject.tag == "Finish") && (laps >= lapsToWin))
        {
            p2win = true;
        }
    }
}
