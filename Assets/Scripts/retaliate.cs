using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retaliate : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other)//when player comes in contact with something 
	{
		if (other.gameObject.tag  == "shot") {
			Debug.Log ("fuck");
			other.gameObject.GetComponent<shooting>().speed = other.gameObject.GetComponent<shooting>().speed*-1;
		}
	}
}
