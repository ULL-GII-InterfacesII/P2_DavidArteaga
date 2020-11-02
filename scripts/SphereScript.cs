using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class SphereScript : MonoBehaviour
{
    private Transform transform;
    private Rigidbody rigidbody;
    public float pushForce = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            GetComponent<Renderer>().material.color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
    }

    void OnTriggerStay(Collider other)
    {
        if (this.gameObject.tag == "SphereA" && other.gameObject.tag == "Player" && Input.GetKey("space"))
        {
            UnityEngine.Debug.Log("Stay");
            Vector3 direction = transform.position - other.transform.position;
            rigidbody.AddForce(direction * pushForce);
        }
    }
}
