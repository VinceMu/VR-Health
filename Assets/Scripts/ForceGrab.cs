using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceGrab : MonoBehaviour
{

    public float threshold = 0.5f;
    public float force = 12;
    public Rigidbody rBody;
    public Transform destination;
    public bool moveFlag = false;
    public Vector3 direction;
    public Vector3 force_vector;

	// Use this for initialization
	void Start () {

        rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        
        if(destination != null && moveFlag)
        {

             direction = destination.position - transform.position;

            direction.Normalize();
            force_vector = force * direction;
            rBody.AddForce(force_vector);

        }
	}

    private void OnTriggerEnter(Collider other)
    {
        destination = other.gameObject.transform;
        moveFlag = true;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = null;
        moveFlag = false;
    }

}
