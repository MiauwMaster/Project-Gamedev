using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bulletscript_p1 : MonoBehaviour
{

    public GameObject Kappa;
    int limit = 8;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
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

        Clone = (Instantiate(Kappa, transform.position, transform.rotation)) as GameObject;


    }
}
