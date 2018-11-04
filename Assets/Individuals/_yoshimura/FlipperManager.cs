using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperManager : MonoBehaviour {

    public GameObject rightFlipper;
    Vector3 rotateCenter = new Vector3(-2f, 0.4f, -1.2f); //回転の中心位置
    Vector3 rotateAxis = new Vector3(0, 1.7f, 1f); //回転の軸
    int angleCount = 0;
    public float flipSpeed = 500;

    // Use this for initialization
    void Start () {
        Rigidbody rRigidBody = rightFlipper.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {

        if ( Input.GetKey( KeyCode.RightArrow ) ) {

            if (angleCount <= 12)
            {
                rightFlipper.transform.RotateAround(
                    new Vector3(-2f, 0.4f, -1.2f),
                    new Vector3(0, 1.7f, 1f),
                    flipSpeed * Time.deltaTime );

                angleCount++;
                //print(angleCount);
            } else
            {
               // 特定の位置に戻す 
            }


        } else
        {
            if ( 0 < angleCount )
            {
                rightFlipper.transform.RotateAround(
                new Vector3(-2f, 0.4f, -1.2f),
                new Vector3(0, 1.7f, 1f),
                -flipSpeed * Time.deltaTime);
                angleCount--;

            } else
            {
                //特定の位置に、、
            }

        }

    }
}
