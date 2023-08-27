using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeliverySystem : MonoBehaviour
{
    private bool hasPackage = false;
    private Color32 noPackageCarColour = new Color32(1, 1, 1, 1);
    private Color32 hasPackageCarColour = new Color32(0, 1, 0, 1);

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Oooft!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case Tags.Package:
                if (hasPackage == false)
                {
                    Debug.Log("Picked up the package...");
                    hasPackage = true;
                    Destroy(collision.gameObject, 0.35f);
                }
                break;
            case Tags.Customer:
                if (hasPackage)
                {
                    Debug.Log("Delivered the package!");
                    hasPackage = false;
                }
                break;
        }
    }
}