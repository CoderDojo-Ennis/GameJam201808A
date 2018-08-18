using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public GameObject cam;
    public GameObject gun;
    public float speed;
    public float travelTime;
    public float damage;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        //rb.velocity += transform.forward * Time.deltaTime * speed;
        rb.AddForce(transform.forward * Time.deltaTime * speed,ForceMode.Impulse);
        StartCoroutine(TravelTime());
    }

	IEnumerator TravelTime()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
     
    }
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "city")
        {
            Destroy(gameObject);
        }
        //if(coll.gameObject.name)
        //Destroy(gameObject);
    }
}
