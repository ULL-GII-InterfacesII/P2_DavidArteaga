using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Transform transform;
    public float zMove, xMove;
    public float playerSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
        transform = GetComponent<Transform>();
        playerSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxis("Horizontal");
        zMove = Input.GetAxis("Vertical");

        transform.position = player.transform.position + new Vector3(xMove, 0, zMove) * playerSpeed * Time.deltaTime;
    }

}
