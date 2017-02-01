using UnityEngine;
using System.Collections;

public class memeMove : MonoBehaviour {

    public float speed = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>.addForce(forward * speed);
        }
	}
}
