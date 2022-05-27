using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CameraMovementBehaviour : MonoBehaviour
{
    public float speed = 3f;
    private float X;
    private float Y;

    void Update()
    {
        if (Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0)
        {
            //transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") *speed, -Input.GetAxis("Mouse X") * speed, 0));
            transform.Rotate(new Vector3(-Input.GetAxis("Vertical") * speed, Input.GetAxis("Horizontal") *speed, 0));
            
            X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(X, Y, 0);
        }
    }

}
