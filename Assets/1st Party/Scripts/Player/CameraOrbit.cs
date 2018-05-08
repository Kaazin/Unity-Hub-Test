using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{

    /*Transform target;

    public float moveH = 45;
    public float moveV = 15;

    float currentX;
    float currentY;
    public Vector3 offset;
    public Transform fulcrum;
    Quaternion currentRot;

    void Awake()
    {
        target = GameObject.Find("Player").transform;

    }
    void Update()
    {

        transform.position = target.position - offset;

        currentX = Input.GetAxis("Mouse X");
        currentY = Input.GetAxis("Mouse Y");


        
            MoveVertical();
          
            MoveHorizontal();

            ZTarget();

       // transform.LookAt(target);


    }

    public void MoveHorizontal()
    {

        transform.RotateAround(fulcrum.position, Vector3.up, moveH * currentX);
    }

    public void MoveVertical()
    {
        transform.RotateAround(target.position, transform.TransformDirection(Vector3.right), moveV * -currentY);
    }

    void ZTarget()
    {
        if(Input.GetMouseButtonDown(2))
        {
            transform.rotation = target.transform.rotation;
        }

   

    }
    */

}
