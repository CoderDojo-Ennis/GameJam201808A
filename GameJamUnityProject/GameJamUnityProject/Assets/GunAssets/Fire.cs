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
        rb.velocity = transform.forward * Time.deltaTime * speed;
        StartCoroutine(TravelTime());
    }

	IEnumerator TravelTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
  
    }
    void OnCollisionEnter(Collision coll)
    {
        //Destroy(gameObject);
    }
}
