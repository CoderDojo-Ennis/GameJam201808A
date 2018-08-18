using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
	void Update ()
    {
		if (Input.GetButtonDown("Flip"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
            transform.rotation = Quaternion.identity;
        }
	}
}
