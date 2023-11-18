using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVolocity;
    public float speed = 5f;
    
    private bool isGrounded;
    public float gravity = -9.8f;

    public float jumpHeight = 2f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        if(isGrounded && playerVolocity.y < 0)
        {
            playerVolocity.y =-2f;
        }
        playerVolocity.y += gravity * Time.deltaTime;
        controller.Move(playerVolocity * Time.deltaTime);
    }
    public void Jump()
    {
        if(isGrounded)
        {
            playerVolocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
}
