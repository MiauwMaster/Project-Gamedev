using UnityEngine;
using System.Collections;

public class lapcounterp1 : MonoBehaviour
{

    public GameObject[] checkPointsList;

    public int checkpointCounter;
    public static int laps;
    public int lapstofinish;
    public bool finish = false;
    public static bool p1win;

	void Start ()
    {
        checkPointsList = GameObject.FindGameObjectsWithTag("CheckPoint");
        laps = 0;
        finish = false;
    }

    void Update()
    {
        if (laps == lapstofinish)
        {
            finish = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "CheckPoint")
        {
            checkpointCounter += 1;
        }

        if ((other.gameObject.tag == "Finish") && (checkpointCounter >= checkPointsList.Length))
        {
            laps += 1;
            checkpointCounter = 0;
        }

        if ((other.gameObject.tag == "Finish") && (finish == true))
        {
            p1win = true;
        }
    }
}
