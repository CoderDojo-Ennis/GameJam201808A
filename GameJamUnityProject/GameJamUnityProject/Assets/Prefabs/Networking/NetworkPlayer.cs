using UnityEngine;
using UnityEngine.Networking;

public class NetworkPlayer : NetworkBehaviour
{
    public float Speed = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            this.transform.Translate(Input.GetAxis("Horizontal") * Speed, 0, Input.GetAxis("Vertical") * Speed);
        }
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        
    }
}
