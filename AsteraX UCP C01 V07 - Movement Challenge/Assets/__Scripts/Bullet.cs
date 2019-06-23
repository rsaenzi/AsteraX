using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
    public float lifetime = 2.0f;
    public float speed = 20.0f;


    void Awake()
    {
        // Destroys the bullet after an specified time
        Destroy(this.gameObject, lifetime);
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}