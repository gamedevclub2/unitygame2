using UnityEngine;
using System.Collections;

public class thomas_flight : MonoBehaviour
{

    public float speed;
    public float yawSpeed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        float moveHoriz = 0;

        if (Input.GetKeyDown(KeyCode.W))
        {
            moveHoriz++;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            moveHoriz--;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {

        }

        if (Input.GetKeyDown(KeyCode.D))
        {

        }

        Vector3 movement = new Vector3(moveHoriz, 0, 0);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Object"))
        {
            collider.gameObject.SetActive(false);
        }
    }
}