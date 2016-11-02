using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

    private float totalTime = 5.0f;
    private float currentTime = 0;
    bool countdown = true;
    public Movementscript Movementscript;
    public Movementscript_p2 Movementscript_p2;
    public GUIStyle countDownGuiStyle;

    void Start()
    {
        Movementscript = GameObject.FindGameObjectWithTag("player1").GetComponent<Movementscript>();
        Movementscript_p2 = GameObject.FindGameObjectWithTag("player2").GetComponent<Movementscript_p2>();

        Movementscript.enabled = false;
        Movementscript_p2.enabled = false;
    }

    void Update()
    {
        DecreaseTime();
    }

    void OnGUI()
    {
        if(countdown)
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "" + totalTime, countDownGuiStyle);
    }

    private void DecreaseTime()
    {
        float delta = Time.deltaTime;

        currentTime += delta;

        if (currentTime >= 1)
        {

            if (totalTime - 1 <= 0)
            {
                Movementscript.enabled = true;
                Movementscript_p2.enabled = true;
                countdown = false;

                totalTime = 0;
            }
            else
            {
                totalTime -= 1;
                currentTime = 0;
                countdown = true;

                Movementscript.enabled = false;
                Movementscript_p2.enabled = false;
            }
        }

    }
}
