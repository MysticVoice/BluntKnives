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
        walk(Input.GetAxis("Vertical"));
        turn(Input.GetAxis("Horizontal"));
        if (Input.GetButtonDown("Jump"))
        {
            jump();
        }
    }

    void turn(float input)
    {
        rb.AddTorque(input * transform.up * turnSpeed, ForceMode.VelocityChange);
    }

    void walk(float input)
    {
        rb.AddForce(input * transform.forward * movementSpeed, ForceMode.VelocityChange);
    }

    void jump()
    {
        rb.AddForce(transform.up * jumpForce,ForceMode.Impulse);
    }
}
