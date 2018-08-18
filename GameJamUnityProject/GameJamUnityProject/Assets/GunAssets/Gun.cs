using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Gun : NetworkBehaviour {
    
    public GameObject Bullet;
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
        GameObject obj = Instantiate(Bullet, 
            transform.position + new Vector3(0,0.5f,0), 
            transform.rotation);
        NetworkServer.Spawn(obj);
    }
}
