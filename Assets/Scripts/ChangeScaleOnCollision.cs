using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public class ChangeScaleOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Cube")
            transform.localScale *= 1.5f;
        else
            transform.localScale /= 1.5f;
    }
}
