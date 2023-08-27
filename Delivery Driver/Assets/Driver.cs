using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 120f;
    [SerializeField] float moveSpeed = 8f;

    void Start()
    {

    }

    void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
