﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementLion : MonoBehaviour
{
    CharacterController characterController;
    SpriteRenderer mySpriteRenderer;
    public float speed = 6.0f;
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveDirection *= speed;

        characterController.Move(moveDirection * Time.deltaTime);//move controller

        bool facingright = false;
        if (Input.GetKeyDown(KeyCode.A))
        {
            //flip sprite
            mySpriteRenderer.flipX = false;
            facingright = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // flip the sprite
            mySpriteRenderer.flipX = true;
            facingright = true;
        }


    }

}