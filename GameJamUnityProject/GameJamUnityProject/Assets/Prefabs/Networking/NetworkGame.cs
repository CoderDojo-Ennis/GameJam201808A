using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/*
public class NetworkGame : NetworkManager
{
NetworkManagerHUD hud;
public static NetworkGame Instance;

public NetworkGame()
{
    Instance = this;
}

// Use this for initialization
void Start()
{
    hud = GetComponent<NetworkManagerHUD>();
}

// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        StopClient();
        hud.enabled = true;
    }
}

public override void OnClientConnect(NetworkConnection conn)
{
    base.OnClientConnect(conn);

    // Hide the hud when playing
    hud.enabled = false;
}

public override void OnClientDisconnect(NetworkConnection conn)
{
    base.OnClientDisconnect(conn);

    // Show the hud when disconnected
    hud.enabled = true;
}
}
*/
