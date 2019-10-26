using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float movementSpeed = 1;
    public float turnSpeed = 0.01f;
    public float gravity = 9.81f;
    public float jumpForce = 5;

    private Vector3 movDir = Vector3.zero;
    private float downSpeed = 0;

    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        move();
        turn();
    }

    private void move()
    {
        if (controller.isGrounded)
        {
            downSpeed = 3;
            //Forward Movement
            Vector3 newDir;
            newDir = transform.forward * Input.GetAxis("Vertical");

            //SidewaysMovement
            newDir += transform.right * Input.GetAxis("Horizontal");
            newDir *= movementSpeed;
            movDir = Vector3.Lerp(movDir,newDir,0.1f);
        }
        //Vertical Movement
        computeVerticalMovement();
        controller.Move(movDir * Time.deltaTime);
        movDir = controller.velocity;
    }

    private void turn()
    {
        Vector3 turnDir = Vector3.zero;
        turnDir = new Vector3(0,Input.GetAxis("Mouse X"),0);
        turnDir *= turnSpeed;
        transform.eulerAngles += turnDir;
    }

    private void jump()
    {
        if(controller.isGrounded)
        {

            float movement = Input.GetAxis("Jump");
            if (movement > 0)
            {
                downSpeed = -jumpForce;
            }
        }
    }

    private void computeVerticalMovement()
    {
        if (!controller.isGrounded)
        {
            downSpeed += 9.81f * Time.deltaTime;
        }
        else
        {
            jump();
        }
        movDir.y = -downSpeed;
    }
}
