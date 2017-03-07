using UnityEngine;
using System.Collections;

public class thomas_flight : MonoBehaviour
{

    public float speed;
    public float yawSpeed;
    private Rigidbody rb;

    float x = 0.0f;
    float y = 0.0f;
    float z = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            z = z + 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            z = z - 1;
        }

        if (Input.GetKey(KeyCode.E))
        {
            x = x + 1;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            x = x - 1;
        }

        Vector3 movement = new Vector3(x, y, z);

        rb.MovePosition(movement * speed);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Object"))
        {
            collider.gameObject.SetActive(false);
        }
    }
}