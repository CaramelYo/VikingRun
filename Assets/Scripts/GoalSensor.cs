using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public class GoalSensor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "viking")
        {
            Debug.Log(other.transform.name + " reached the goal!");
        }
    }
}
