using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{
    public Rigidbody car;
    private Text text;

	void Start ()
    {
        text = GetComponent<Text>();
	}
	
	void Update ()
    {
        float carSpeed = car.velocity.magnitude; //in metres per second
        carSpeed /= 1000; //kilometres per second
        carSpeed *= 3600; //kilometres per hour
        text.text = car.velocity.magnitude.ToString("F0") + " km/h"; //"F0" means round to 0 decimal places
	}
}
