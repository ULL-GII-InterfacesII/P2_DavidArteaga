using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    private Transform transform;
    private GameObject player;
    private Rigidbody rigidbody;
    public float minimumDistance = 3;
    public float pushForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        player = GameObject.FindWithTag("Player");
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < minimumDistance)
        {
            Vector3 direction = transform.position - player.transform.position;
            rigidbody.AddForce(direction * pushForce);
        }
    }
}
