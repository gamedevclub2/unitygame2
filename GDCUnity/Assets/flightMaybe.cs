using UnityEngine;
using System.Collections;

public class flightMaybe : MonoBehaviour {

    public bool jKey = false;
    public Rigidbody rb;
    public float speed1 = 1.0f;
    public float speedF;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            jKey = true;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            jKey = false;
        }
	}

    // Called every physics update
    void FixedUpdate()
    {
        if (jKey == true)
        {
            rb.AddForce(transform.forward * speed1);
        }
        if (jKey == false && speedF >= 0)
        {
            rb.AddForce(transform.forward * -speed1);
        }
        if (speedF <= 0)
        {
            rb.velocity = Vector3.zero;
        }
            speedF = rb.velocity.magnitude;
    }
}
