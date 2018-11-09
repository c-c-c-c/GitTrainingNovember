using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperManager : MonoBehaviour {

    public GameObject rightFlipper;
    public GameObject leftFlipper;
    Vector3 rotateCenterR = new Vector3(-1.4f, 0.4f, -1f); //回転の中心位置
    Vector3 rotateCenterL = new Vector3(1.4f, 0.4f, -1f); //回転の中心位置
    int angleCountR = 0;
    int angleCountL = 0;
    public float flipSpeed = 500;
    Vector3 norm;
    Quaternion rightDefaultRot;
    Quaternion leftDefaultRot;

    // Use this for initialization
    void Start () {
        Rigidbody rRigidBody = rightFlipper.GetComponent<Rigidbody>();

        GameObject cube = GameObject.Find("__CubeMeyasu");
        norm = cube.transform.rotation * new Vector3(0, 1, 0);
        rightDefaultRot = rightFlipper.transform.rotation;
        leftDefaultRot = leftFlipper.transform.rotation;

    }

    // Update is called once per frame
    void Update () {

        if ( Input.GetKey( KeyCode.RightArrow ) ) {

            if (angleCountR <= 12)
            {
                rightFlipper.transform.RotateAround(
                    rotateCenterR,
                    norm,
                    flipSpeed * Time.deltaTime );

                angleCountR++;
            } else
            {
               // 特定の位置に戻す 
            }


        } else
        {
            if ( 0 < angleCountR )
            {
                rightFlipper.transform.RotateAround(
                rotateCenterR,
                norm,
                -flipSpeed * Time.deltaTime);
                angleCountR--;

            } else
            {
                //特定の位置に、、
                rightFlipper.transform.rotation = rightDefaultRot;
            }

        }

        if ( Input.GetKey( KeyCode.LeftArrow ) ) {

            if (angleCountL <= 12)
            {
                leftFlipper.transform.RotateAround(
                    rotateCenterL,
                    norm,
                    -flipSpeed * Time.deltaTime );

                angleCountL++;
            } else
            {
               // 特定の位置に戻す 
            }


        } else
        {
            if ( 0 < angleCountL )
            {
                leftFlipper.transform.RotateAround(
                    rotateCenterL,
                    norm,
                    flipSpeed * Time.deltaTime);
                angleCountL--;

            } else
            {
                //特定の位置に、、
                leftFlipper.transform.rotation = leftDefaultRot;
            }

        }


    }
}
