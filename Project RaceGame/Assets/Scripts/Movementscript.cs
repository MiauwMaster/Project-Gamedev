using UnityEngine;
using System.Collections;

public class Movementscript : MonoBehaviour {

	
    Rigidbody2D rigidbody2d;
    public float speed = 2000F;
    public float backwspeed = 1800F;
    public float turnSpeed = 2;
    public Rigidbody2D rb;
    // Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            rb.AddForce(-(transform.forward) * backwspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            //rb.transform.Rotate(0, 0, 2);
            rb.transform.Rotate(Vector3.forward * turnSpeed);
            
        }
        if (Input.GetKey(KeyCode.A)) { 
            //rb.transform.Rotate(0, 0, -2);
            rb.transform.Rotate(Vector3.forward * -turnSpeed);
        }
    }
}
