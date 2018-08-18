using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Gun : NetworkBehaviour {
    
    public GameObject bullet;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0) && isLocalPlayer)
        {
            CmdShoot();
        }
    }
    [Command]
    void CmdShoot()
    {
        Instantiate(bullet, 
            transform.position, 
            transform.rotation);

        NetworkServer.Spawn(bullet);
    }
}
