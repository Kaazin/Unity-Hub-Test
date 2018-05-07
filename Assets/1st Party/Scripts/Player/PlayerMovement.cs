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
        float moveV = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveH = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (moveH != 0 || moveV != 0)
        {
           // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(dir.x, dir.y, dir.z)), 1);
        }

        dir = new Vector3(moveH, 0, moveV) * speed * Time.deltaTime;
        transform.Translate(transform.rotation * new Vector3(-dir.x,dir.y,dir.z));
    }

  
}
