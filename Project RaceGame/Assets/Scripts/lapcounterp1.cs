﻿using UnityEngine;
using System.Collections;

public class lapcounterp1 : MonoBehaviour {

    public GameObject[] checkPointsList;
    public GameObject finish;

    public int checkpointCounter;
    public int laps;

	void Start () {
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
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 40, 150, 20), "laps: " + laps);
    }
}