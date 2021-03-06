﻿using UnityEngine;
using System.Collections;

public class Pokret : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 20.0F;
                Debug.Log("Pritisnut shift");
            }

            else
            {
                speed = 6.0F;
            }
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        float roty = Input.GetAxis("Mouse X");
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        this.transform.Rotate(0, roty, 0);
    }
}