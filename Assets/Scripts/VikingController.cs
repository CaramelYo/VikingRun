using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class VikingController : MonoBehaviour
{
    public Vector3 MovingDirection;
    public float JumpingForce;

    //MeshRenderer mr;
    Rigidbody rb;
    [SerializeField]float movingSpeed = 10f;
    bool onGround = false;

    NavMeshAgent agent;


    void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        //mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        agent = GetComponent<NavMeshAgent>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "big_module_01_floor")
        {
            onGround = true;
            Debug.Log("on ground = " + collision.transform.name);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.name == "big_module_01_floor")
        {
            onGround = false;
            Debug.Log("not on ground = " + collision.transform.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //// move over time
        //transform.localPosition += movingSpeed * Time.deltaTime * MovingDirection;

        //// change color over time
        //mr.material.color = new Color((int)Time.time % 2 * 1.0f, 1.0f, 1.0f);


        // move by the key
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
        }


        // jump
        if (onGround & Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(JumpingForce * Vector3.up);
        }


        // destroy a coin when it is clicked by mouse
        if (Input.GetMouseButtonDown(0))
        {
            // 2D to 3D
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // a structure used to get information back from a raycast
            RaycastHit raycastHit;

            // raycasting
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.transform.name.Contains("Viking_Shield_Coin"))
                    Destroy(raycastHit.transform.gameObject);
            }
        }


        //// walk to the position mouse clicked by nav agent
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    RaycastHit raycastHit;

        //    if (Physics.Raycast(ray, out raycastHit))
        //    {
        //        agent.SetDestination(raycastHit.point);
        //    }
        //}
    }
}
