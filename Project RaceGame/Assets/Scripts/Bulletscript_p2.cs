using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bulletscript_p2 : MonoBehaviour
{

    public GameObject Pepe1;
    int limit = 8;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (limit > 0)
            {
                Firebullet();

                limit -= 1;
            }

        }

    }

    public void Firebullet()
    {
        GameObject Clone;

        Clone = (Instantiate(Pepe1, transform.position, transform.rotation)) as GameObject;
    }
}
