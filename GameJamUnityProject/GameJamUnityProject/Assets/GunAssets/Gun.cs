﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public Transform cameraDirection;
    public GameObject bullet;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            ;
        }
    }
}