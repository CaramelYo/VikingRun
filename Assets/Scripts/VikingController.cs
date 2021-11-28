using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class VikingController : MonoBehaviour
{
    public Vector3 MovingDirection;

    MeshRenderer mr;
    [SerializeField]float movingSpeed = 10f;
    NavMeshAgent agent;


    void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //// move over time
        //transform.localPosition += movingSpeed * Time.deltaTime * MovingDirection;

        //// change color over time
        //mr.material.color = new Color((int)Time.time % 2 * 255f, 255f, 255f);

        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                agent.SetDestination(raycastHit.point);
            }
        }
    }
}
