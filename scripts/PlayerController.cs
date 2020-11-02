﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Transform transform;
    public bool zMove, xMove;
    public float yRotation;
    public float playerSpeed;
    public float rotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
        transform = GetComponent<Transform>();
        
        playerSpeed = 5;
        rotationSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetButton("Horizontal");
        zMove = Input.GetKey("w");
        yRotation = Input.GetAxis("Horizontal");

        if (zMove)
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        if (xMove)
            transform.Rotate(0, yRotation * rotationSpeed, 0);
    }

}
