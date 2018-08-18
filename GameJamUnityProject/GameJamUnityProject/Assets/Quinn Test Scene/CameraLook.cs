using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraLook : NetworkBehaviour
{
    public float HorizontalSens;
    public float VerticalSens;
    private float H;
    private float V;
    private bool DoLook = true;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        if (transform.parent.GetComponent<CarScript>().isLocalPlayer)
        {
            if (DoLook)
            {
                H += HorizontalSens * (Input.GetAxis("Mouse X") + Input.GetAxis("RightStickHorizontal")); //Horizontal RightStickHorizontal mouse X
                V -= VerticalSens * (Input.GetAxis("Mouse Y") + Input.GetAxis("RightStickVertical")); //Vertical RightStickVertical mouse Y
                transform.eulerAngles = new Vector3(V, H, 0.0f);
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                DoLook = false;
            }

            if (Input.GetMouseButtonDown(0))
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                DoLook = true;
            }
        }
    }
}
