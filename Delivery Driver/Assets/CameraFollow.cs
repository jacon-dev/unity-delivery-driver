using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject playerCar;

    void LateUpdate()
    {
        transform.position = playerCar.transform.position + new Vector3(0, 0, -11f);
    }
}
