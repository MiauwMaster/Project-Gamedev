using UnityEngine;
using System.Collections;

public class ongui : MonoBehaviour {

	void OnGUI()
    {
        //player 1
        GUI.Label(new Rect(10, 10, 150, 20), "Fuel: " + Fuelscript_p1.fuelcount);
        GUI.Label(new Rect(10, 25, 150, 20), "Pitstops: " + pitstop.p1Pitstop);
        GUI.Label(new Rect(10, 40, 150, 20), "Laps: " + lapcounterp1.laps);
        GUI.Label(new Rect(10, 55, 150, 20), "Speed: " + Movementscript.speed);

        //player2
        GUI.Label(new Rect(Screen.width - 100, 10, 100, 50), "Fuel: " + Fuelscript_p2.fuelcount);
        GUI.Label(new Rect(Screen.width - 100, 25, 100, 50), "Pitstops: " + pitstop.p2Pitstop);
        GUI.Label(new Rect(Screen.width - 100, 40, 100, 50), "Laps: " + lapcounterp2.laps);
        GUI.Label(new Rect(Screen.width - 100, 55, 100, 50), "Speed: " + Movementscript_p2.speed);
    }
}
