using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeliverySystem : MonoBehaviour
{
    private bool hasPackage = false;
    [SerializeField] Color noPackageCarColour = new Color(1, 1, 1, 1);
    [SerializeField] Color hasPackageCarColour = new Color(0, 1, 0, 1);
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageCarColour;
    }

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
                    spriteRenderer.color = hasPackageCarColour;
                }
                break;
            case Tags.Customer:
                if (hasPackage)
                {
                    Debug.Log("Delivered the package!");
                    hasPackage = false;
                    spriteRenderer.color = noPackageCarColour;
                }
                break;
        }
    }
}