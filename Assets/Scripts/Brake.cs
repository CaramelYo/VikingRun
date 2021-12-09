using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Brake : MonoBehaviour
{
    public float BrakeDistance;
    public float BrakeScale;

    Rigidbody rb;
    bool braked;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        braked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (braked)
            return;


        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, -transform.right, out raycastHit))
            if (Vector3.Distance(transform.position, raycastHit.transform.position) <= BrakeDistance)
            {
                rb.velocity *= BrakeScale;
                braked = true;
            }
    }
}
