using UnityEngine;
using System.Collections;

public class ongui : MonoBehaviour {

    public GUIStyle lowFuelGUIStyle;

    Vector2 camp1;
    Vector2 camp2;

    public int lowFuelthreshold;

    void Update()
    {
        foreach (Camera c in Camera.allCameras)
        {
            if (c.gameObject.name == "camerap1")
            {
                camp1.x = Screen.width * 0.25f;
                camp1.y = Screen.height * 0.5f;
            }

            if (c.gameObject.name == "camerap2")
            {
                camp2.x = Screen.width * 0.75f;
                camp2.y = Screen.height * 0.5f;
            }
        }
    }

	void OnGUI()
    {
        //player 1
        GUI.Label(new Rect(10, 10, 150, 20), "Fuel: " + Mathf.RoundToInt(Fuelscript_p1.fuelcount));
        GUI.Label(new Rect(10, 25, 150, 20), "Pitstops: " + pitstop.p1Pitstop);
        GUI.Label(new Rect(10, 40, 150, 20), "Laps: " + lapcounterp1.laps);
        GUI.Label(new Rect(10, 55, 150, 20), "Speed: " + Movementscript.speed);

        if (Fuelscript_p1.fuelcount <= lowFuelthreshold)
        {
            
            GUI.Label(new Rect(camp1.x - 50, camp1.y - 25, 100, 50), "LOW FUEL!", lowFuelGUIStyle);
        }

        //player2
        GUI.Label(new Rect(Screen.width - 100, 10, 100, 50), "Fuel: " + Mathf.RoundToInt(Fuelscript_p2.fuelcount));
        GUI.Label(new Rect(Screen.width - 100, 25, 100, 50), "Pitstops: " + pitstop.p2Pitstop);
        GUI.Label(new Rect(Screen.width - 100, 40, 100, 50), "Laps: " + lapcounterp2.laps);
        GUI.Label(new Rect(Screen.width - 100, 55, 100, 50), "Speed: " + Movementscript_p2.speed);

        if (Fuelscript_p2.fuelcount <= lowFuelthreshold)
        {
            GUI.Label(new Rect(camp2.x - 50, camp2.y - 25, 100, 50), "LOW FUEL!", lowFuelGUIStyle);
        }
    }
}
