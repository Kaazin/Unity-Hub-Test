using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Vector3 dir;
    Vector3 myDirection;
    Camera cam;
    // Use this for initialization
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        myDirection = cam.transform.forward;
        myDirection.y = 0;
        transform.rotation *= Quaternion.Euler(0, cam.transform.rotation.y, 0);

        float moveV = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveH = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        dir = new Vector3(moveH,0,moveV) * speed * Time.deltaTime;

        if (moveH != 0 || moveV != 0)
        {
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 1);
        }

        transform.Translate(dir);
    }


}