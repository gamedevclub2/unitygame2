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
        float x = rb.position.x;
        float y = rb.position.y;
        float z = rb.position.z;

        if (Input.GetKey(KeyCode.W))
        {
            z = z + 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            z = z + 1;
        }

        if (Input.GetKey(KeyCode.E))
        {
            x = x + 1;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            x = x + 1;
        }

        if(Input.mousePosition.y < winY - 30)
        {
            Vector3 angle = new Vector3(15, 0, 0);
            Quaternion deltaRot = Quaternion.Euler(angle * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRot);
        }

        if (Input.mousePosition.y > winY + 30)
        {
            Vector3 angle = new Vector3(15, 0, 0);
            Quaternion deltaRot = Quaternion.Euler(-angle * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRot);
        }

        if (Input.mousePosition.x < winX - 20)
        {
            Vector3 angle = new Vector3(0, 0, 15);
            Quaternion deltaRot = Quaternion.Euler(-angle * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRot);
        }

        if (Input.mousePosition.x > winX + 20)
        {
            Vector3 angle = new Vector3(0, 0, 15);
            Quaternion deltaRot = Quaternion.Euler(angle * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRot);
        }

        Vector3 movePos = new Vector3(x, y, z);
        rb.MovePosition(movePos);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Object"))
        {
            collider.gameObject.SetActive(false);
        }
    }
}