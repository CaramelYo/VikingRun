using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class TorqueDealer : MonoBehaviour
{
    public Vector3 TorqueDirection;
    public float RotationTorque;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // mouse left click
        if (Input.GetMouseButtonDown(0))
            rb.AddTorque(RotationTorque * TorqueDirection);
        // mouse right click
        if (Input.GetMouseButtonDown(1))
            rb.AddTorque(-RotationTorque * TorqueDirection);

    }
}
