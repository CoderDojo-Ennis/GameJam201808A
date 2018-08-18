using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO:
//Assign the public variables as needed in the inspector
//Add check for the car's team
//Check the tags "Car" and "Projectile" actually exist
//Check code works
public class Flag : MonoBehaviour 
{
	public bool Carried = false;
	public string Owner = "Team1";
	public GameObject Car;
	public Transform FlagTransform;

	void OnEnable()
	{
		StartCoroutine(ControlFlag());
	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "Car")
		{
			Carried = true;
			transform.parent = coll.transform;
			Car = coll.gameObject;
		}

		if (coll.gameObject.tag == "Projectile")
		{
			Carried = false;
			transform.parent = null;
			Car = null;
		}
	}

	void ControlFlag()
	{
		while (Carried)
		{
			gameObject.transform = Car.transform;
		}

		while (!Carried)
		{
			StartCoroutine(RespawnFlag());
		}
	}

	IEnumerator RespawnFlag ()
	{
		WaitForSeconds(15);
		if (!Carried && transform != FlagTransform)
		{
			transform = FlagTransform;
		}
	}
}
