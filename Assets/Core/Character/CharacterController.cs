using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float movementSpeed = 1;
    public float turnSpeed = 1;
    public float jumpForce = 1;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        walk();
        turn();
        jump();
    }

    void turn()
    {
        rb.AddTorque(Input.GetAxis("Horizontal") * transform.up * turnSpeed, ForceMode.VelocityChange);
    }

    void walk()
    {
        rb.AddForce(Input.GetAxis("Vertical") * transform.forward * movementSpeed, ForceMode.VelocityChange);
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(transform.up * jumpForce,ForceMode.Impulse);
        }
    }
}
