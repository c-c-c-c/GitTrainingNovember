using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperManager : MonoBehaviour {

    public GameObject rightFlipper;
    Vector3 normVec;
    int angleCount = 0;
    public float flipSpeed = 200;

    // Use this for initialization
    void Start () {
        Rigidbody rRigidBody = rightFlipper.GetComponent<Rigidbody>();
        print(rRigidBody);
        GameObject obj = GameObject.Find("__CubeMeyasu");

    }

    // Update is called once per frame
    void Update () {

        if ( Input.GetKey( KeyCode.RightArrow ) ) {
            rightFlipper.transform.RotateAround(
                new Vector3(-2f, 0.4f, -1.2f),
                new Vector3(0, 1.7f, 1f),
                flipSpeed * Time.deltaTime);

            angleCount++;
            print(angleCount);
        }
        print(rightFlipper.transform.rotation);
    }
}
