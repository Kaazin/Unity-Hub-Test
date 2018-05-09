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

        float moveV = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveH = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        dir = new Vector3(moveH,0,moveV) * speed * Time.deltaTime;
        Vector3 moveDir = Vector3.Scale(myDirection, dir);
       transform.Translate(moveDir);

        Vector3 myDir;
        myDir = cam.transform.forward;
        myDir.y = 0;

        dir = Vector3.Scale(new Vector3(moveH, 0, moveV), myDir)  * speed * Time.deltaTime;


        Vector3 currentDir = Vector3.Scale(myDir, dir);

        transform.Translate(dir);
    }


}