using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCustomizer : MonoBehaviour
{
    public Vector3 NewGravity;

    Vector3 originalGravity;


    // Start is called before the first frame update
    void Start()
    {
        originalGravity = Physics.gravity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Physics.gravity = NewGravity;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Physics.gravity = originalGravity;
        }
    }
}
