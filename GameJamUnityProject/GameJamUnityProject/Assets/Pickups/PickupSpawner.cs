using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour 
{
	public GameObject Pickup;
	void OnEnable ()
	{
		StartCoroutine(SpawnPickups());
	}

	IEnumerator SpawnPickups()
	{
		while (true)
		{
			yield return new WaitForSeconds(15);
			Instantiate(Pickup, transform.position, transform.rotation, transform);
		}
	}
}
