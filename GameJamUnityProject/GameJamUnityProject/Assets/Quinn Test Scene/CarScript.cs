using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CarScript : NetworkBehaviour
{
    [SyncVar]
    GameObject equippedWeapon;

    public Transform WeaponPosition;
    public Transform CamLookAt;
    public Transform CamPos;
    public Transform GunParent;
    private List<GameObject> Guns = new List<GameObject>();

    private void Start()
    {
        AssignCamera();
        foreach(Transform t in GunParent)
        {
            Guns.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }
    }

    void AssignCamera()
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

        if (equippedWeapon != null)
        {
            foreach (GameObject g in Guns) { g.SetActive(false); }
            equippedWeapon.SetActive(true);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            string wepName = other.GetComponent<Pickup>().weapon;
            foreach (GameObject g in Guns)
            {
                if (g.name == wepName)
                {
                    g.SetActive(true);
                    equippedWeapon = g;
                }
                else
                {
                    g.SetActive(false);
                }
            }
            /*
            if (equippedWeapon != null)
            {
                Destroy(equippedWeapon);
            }
            equippedWeapon = Instantiate(Resources.Load(other.GetComponent<Pickup>().weapon) as GameObject, WeaponPosition.position, Quaternion.identity, transform);
            */
            Destroy(other.gameObject);
        }
    }
}
