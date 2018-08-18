using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public Transform Head;
    public float DelayBetweenShots = 0.1f; //in seconds
    private Camera cam;
    private float ShootTimer = 0;

    private void Start()
    {
        cam = Camera.main;
    }

    void Update ()
    {
        if (GetComponentInParent<CarScript>().isLocalPlayer)
        {
            ShootTimer -= Time.deltaTime;
            Head.LookAt(cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 100)));

            if (Input.GetButton("Shoot") && ShootTimer < 0)
            {
                ShootTimer = DelayBetweenShots;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(Head.position, Head.forward, out hit))
        {
            hit.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y + 50, hit.transform.position.z);
        }
    }
}
