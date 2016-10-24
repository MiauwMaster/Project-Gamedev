using UnityEngine;
using System.Collections;

public class Movementscript : MonoBehaviour {

	
    Rigidbody2D rigidbody2d;
    public float speed = 20F;
    public float backwspeed = 8F;
    Rigidbody2D rigidbody;
    // Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W)) {
            rigidbody.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.AddForce(-(transform.forward) * backwspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 2, 0);
        }
        if (Input.GetKey(KeyCode.A)) { 
            transform.Rotate(0, -2, 0);
        }
    }
}
