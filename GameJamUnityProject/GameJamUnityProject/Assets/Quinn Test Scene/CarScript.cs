using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public string equippedWeapon = "";

	void Update ()
    {
		if (Input.GetButtonDown("Flip"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
            transform.rotation = Quaternion.identity;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            equippedWeapon = other.GetComponent<Pickup>().weapon;
            Destroy(other.gameObject);
        }
    }
}
