using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
public class ChangeColorOnCollisionStay : MonoBehaviour
{
    MeshRenderer mr;


    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.name == "bullet")
            mr.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
