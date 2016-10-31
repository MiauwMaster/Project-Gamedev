using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bulletscript_p2 : MonoBehaviour
{

    GameObject Bulletprefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightShift))
        {
            Firebullet();
        }

    }

    public void Firebullet()
    {
        GameObject Clone;

        Clone = (Instantiate(Bulletprefab, transform.position, transform.rotation)) as GameObject;

        Clone.GetComponent<Rigidbody>().AddForce(1000, 0, 0);
    }
}
