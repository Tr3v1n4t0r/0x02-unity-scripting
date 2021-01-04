﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 750f;
    public GameObject other;

    private Rigidbody Rb3D;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        Rb3D = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 roll = new Vector3(horizontal, 0, vertical);
        roll = roll * speed * Time.deltaTime;
        Rb3D.AddForce(roll);
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        Debug.Log($"Score: {score}");
        Destroy(other.gameObject);
    }
}
