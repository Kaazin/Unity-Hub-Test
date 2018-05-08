using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Vector3 dir;
    public Camera cam;

	// Use this for initialization
	void Awake ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 myDir;
        myDir = cam.transform.forward;
        myDir.y = 0;

        float moveV = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        float moveH = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        dir = Vector3.Scale(new Vector3(moveH, 0, moveV), myDir)  * speed * Time.deltaTime;


        Vector3 currentDir = Vector3.Scale(myDir, dir);

        transform.Translate(dir);
    }

  
}
