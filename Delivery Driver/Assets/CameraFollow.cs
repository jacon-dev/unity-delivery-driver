using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject playerCar;

    void Update()
    {
        transform.position = playerCar.transform.position + new Vector3(0, 0, -11f);
    }
}
