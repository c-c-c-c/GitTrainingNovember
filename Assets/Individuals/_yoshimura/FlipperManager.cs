using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperManager : MonoBehaviour {

    public GameObject rightFlipper;
    Vector3 normVec;

    // Use this for initialization
    void Start () {
        Rigidbody rRigidBody = rightFlipper.GetComponent<Rigidbody>();
        print(rRigidBody);
        //rRigidBody.centerOfMass = new Vector3(-2f, 0.4f, 1.2f);
        GameObject obj = GameObject.Find("__CubeMeyasu");
        //MeshFilter mf = obj.GetComponent<MeshFilter>();
        //Vector3[] nor = mf.mesh.normals;
        //foreach ( var i  in nor )
        //{
        //    print(i);
        //}
        Vector3 a = new Vector3(1, 0, 0);
        Vector3 b = new Vector3(0, 0.5f, Mathf.Sqrt(3));
        normVec = Vector3.Cross(a, b) + new Vector3(-0, 0, 0);
        print(normVec);

    }

    // Update is called once per frame
    void Update () {
        rightFlipper.transform.RotateAround(
            new Vector3(-2f, 0.4f, -1.2f),
            //new Vector3(-4f, 0.8f, -2.4f),
            //new Vector3(0, 1.7f, -1f),
            new Vector3(0, 1.7f, 1f),
            //normVec,
            //normVec,
            40 * Time.deltaTime);

    }
}
