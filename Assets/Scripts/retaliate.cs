using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retaliate : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other)//when player comes in contact with something 
	{
		if (other.gameObject.tag  == "Shot") {
			Debug.Log ("fuck");
			other.gameObject.GetComponent<Shooting>().speed = other.gameObject.GetComponent<Shooting>().speed*-1;
		}
	}
}
