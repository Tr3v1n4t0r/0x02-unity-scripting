using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody Rb3D;

    // Start is called before the first frame update
    void Start()
    {
        Rb3D = GetComponent<Rigidbody>();
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
}
