using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 120f;
    [SerializeField] float moveSpeed = 12f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case Tags.Boost:
                moveSpeed = boostSpeed; 
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
