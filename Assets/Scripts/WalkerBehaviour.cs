using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerBehaviour : MonoBehaviour {

    public float WalkerSpeed;

    private Rigidbody rb;
    
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        float Hori = Input.GetAxis("Horizontal");
        float Verti = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(Hori, 0.0f, Verti);

        rb.AddForce(mov * WalkerSpeed);
        
	}
}
