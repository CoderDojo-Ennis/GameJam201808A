using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour 
{
	public string weapon;
	public Material cannonMaterial;
	public Material machineGunMaterial;
	public Material missileLauncherMaterial;

	void RandomWeapon ()
	{
		List<string> weapons = new List<string>
		{
			"Cannon",
			"Machine Gun",
			"Missile Launcher"
		};
		weapon = weapons[Random.Range(0, weapons.Count)];
	}

	void OnEnable()
	{
		RandomWeapon();
		ChangeTexture();
	}

	void FixedUpdate ()
	{
		transform.Rotate(0, 0, 2);
	}

	void ChangeTexture ()
	{
		MeshRenderer renderer = GetComponent<MeshRenderer>();
		switch (weapon)
		{
			case "Cannon":
				renderer.material = cannonMaterial;
				break;
			case "Machine Gun":
				renderer.material = machineGunMaterial;
				break;
			case "Missile Launcher":
				renderer.material = missileLauncherMaterial;
				break;	
		}
	}
}
