using UnityEngine;
using System.Collections;

public class thomas_flight : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;

    int winX = Screen.width / 2;
    int winY = Screen.height / 2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void FixedUpdate()
    {

        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            rb.AddRelativeForce(Vector3.right * speed);
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            rb.AddRelativeForce(Vector3.left * speed);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Object"))
        {
            collider.gameObject.SetActive(false);
        }
    }
}