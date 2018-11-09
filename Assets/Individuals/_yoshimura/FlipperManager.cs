using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperManager : MonoBehaviour {

    public GameObject rightFlipper;
    public GameObject leftFlipper;
    Vector3 rotateCenterR = new Vector3(-1.9f, 0.4f, -1f); //回転の中心位置
    Vector3 rotateCenterL = new Vector3(1.9f, 0.4f, -1f); //回転の中心位置
    int angleCountR = 0;
    int angleCountL = 0;
    public float flipSpeed ;
    Vector3 norm;
    Vector3 rightDefaultPos;
    Vector3 leftDefaultPos;
    Quaternion rightDefaultRot;
    Quaternion leftDefaultRot;
    Rigidbody rrb;
    Rigidbody lrb;

    // Use this for initialization
    void Start () {
        Rigidbody rRigidBody = rightFlipper.GetComponent<Rigidbody>();

        GameObject cube = GameObject.Find("__CubeMeyasu");
        norm = cube.transform.rotation * Vector3.up;
        rightDefaultRot = rightFlipper.transform.rotation;
        leftDefaultRot = leftFlipper.transform.rotation;
        rightDefaultPos = rightFlipper.transform.position;
        leftDefaultPos = leftFlipper.transform.position;

        rrb = rightFlipper.GetComponent<Rigidbody>()  ;
        lrb = leftFlipper.GetComponent<Rigidbody>()  ;
        //rb.centerOfMass = rotateCenterR;
    }

    // Update is called once per frame
    void Update () {

        if ( Input.GetKey( KeyCode.RightArrow ) ) {

            if (angleCountR <= 12)
            {

                rrb.MoveRotation(Quaternion.AngleAxis( 4*angleCountR, norm));

                angleCountR++;
            } else
            {
               // 特定の位置に戻す 
            }


        } else
        {
            if ( 0 < angleCountR )
            {
                rrb.MoveRotation(Quaternion.AngleAxis( -4*angleCountR, norm));
                angleCountR--;

            } else
            {
                //特定の位置に、、
                rightFlipper.transform.rotation = rightDefaultRot;
                rightFlipper.transform.position = rightDefaultPos;
            }

        }

        if ( Input.GetKey( KeyCode.LeftArrow ) ) {

            if (angleCountL <= 12)
            {
                lrb.MoveRotation(Quaternion.AngleAxis( -4*angleCountL, norm));

                angleCountL++;
            } else
            {
               // 特定の位置に戻す 
            }



        } else
        {
            if ( 0 < angleCountL )
            {
                lrb.MoveRotation(Quaternion.AngleAxis( 4*angleCountL, norm));
                angleCountL--;

            } else
            {
                //特定の位置に、、
                leftFlipper.transform.rotation = leftDefaultRot;
                leftFlipper.transform.position = leftDefaultPos;
            }

        }


    }
}
