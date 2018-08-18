using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public GameObject gun;
    private float H = 0.0f;
    private float V = 0.0f;
    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //Instantiate(gun, transform);
        //if(Input.GetAxis("Cancel")) 
	}
	
	// Update is called once per fram

    void Update()
    {
        H += speedH * Input.GetAxis("Mouse X"); //Horizontal RightStickHorizontal  mouse X
        V -= speedV * Input.GetAxis("Mouse Y"); //Vertical RightStickVertical mouse Y

        transform.eulerAngles = new Vector3(V, H, 0.0f);
    }
}

