using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCarBehaviour : MonoBehaviour
{
    public float CarSpeed;
    public float TurnSpeed;

    public GameObject Walky;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        Vector3 Direction = (Walky.transform.position - transform.position) ;

        transform.forward = Direction.normalized ;

        transform.position += ((Direction * (Time.deltaTime * CarSpeed)));

        Vector3 p = transform.position;

        Quaternion r = transform.rotation;

        if (p.y > 1)
        {
           p.y = 1;
           transform.position = p;
        }

        if (p.y < 1)
        {
            p.y = 1;
            transform.position = p;
        }

        if (r.x < 0)
        {
            r.x = 0;
            transform.rotation = r;
        }

        if (r.x > 0)
        {
            r.x = 0;
            transform.rotation = r;
        }

        if (r.z < 0)
        {
            r.z = 0;
            transform.rotation = r;
        }

        if (r.z > 0)
        {
            r.z = 0;
            transform.rotation = r;
        }

    }
}
