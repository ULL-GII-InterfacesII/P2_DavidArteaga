using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Expand : MonoBehaviour
{
    private GameObject player;
    private GameObject sphere;
    private GameObject sphereA;
    private Transform transform;
    public float minimumDistance = 2;
    public float increment = 1.005F;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        sphere = GameObject.FindWithTag("Sphere");
        sphereA = GameObject.FindWithTag("SphereA");
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bool playerNear = Vector3.Distance(transform.position, player.transform.position) < minimumDistance;
        bool sphereNear = Vector3.Distance(transform.position, sphere.transform.position) < minimumDistance;
        bool sphereANear = Vector3.Distance(transform.position, sphereA.transform.position) < minimumDistance;
        
        if (playerNear)
            transform.localScale *= increment; 

        if (sphereNear || sphereANear)
            transform.localScale /= increment;
    }
}
