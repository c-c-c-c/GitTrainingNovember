using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperManager : MonoBehaviour {

    public GameObject rightFlipper;

	// Use this for initialization
	void Start () {
        Rigidbody rRigidBody = rightFlipper.GetComponent<Rigidbody>();
        print(rRigidBody);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
