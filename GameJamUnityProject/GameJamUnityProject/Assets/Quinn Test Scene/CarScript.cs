using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CarScript : NetworkBehaviour
{
    GameObject equippedWeapon;
    public Transform WeaponPosition;
    public Transform CamLookAt;
    public Transform CamPos;

    private void Start()
    {
        if (isLocalPlayer)
        {
            CameraController c = Camera.main.GetComponent<CameraController>();
            c.lookAtTarget = CamLookAt;
            c.positionTarget = CamPos;
        }
    }

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
            if (equippedWeapon != null)
            {
                Destroy(equippedWeapon);
            }
            equippedWeapon = Instantiate(Resources.Load(other.GetComponent<Pickup>().weapon) as GameObject, WeaponPosition.position, Quaternion.identity, transform);
            Destroy(other.gameObject);
        }
    }
}
