using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float MovingSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Input.GetAxis("Vertical") * MovingSpeed * Time.deltaTime * Vector3.up;
    }
}
