using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatform : MonoBehaviour {

	public Transform target;
	public Transform[] stops;
	public GameObject player;
	public int number;
	public float step;
	// Use this for initialization
	void Start () {
		target = stops[0];
		number = 0;
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
			transform.position = Vector2.MoveTowards (transform.position, target.transform.position, step);

		if (Vector2.Distance(transform.position,target.position)<0.5f){
			number++;
			number %= stops.Length;
			target = stops [number];
		}
		if (player.GetComponent<movementScript>().airborne) {
			player.transform.parent = null;
		}

	}
	void OnCollisionEnter2D (Collision2D other)//when player comes in contact with something 
	{
		if (other.gameObject.tag == "Player") {
			//Sets "newParent" as the new parent of the player GameObject.
			player.transform.SetParent(GameObject.Find("floating platform").transform);

			//Same as above, except this makes the player keep its local orientation rather than its global orientation.
			player.transform.SetParent(GameObject.Find("floating platform").transform,false);
	
		}
	}
	void	OnCollosionExit2D(Collision2D other)
	{
		player.transform.parent = null;
	}

}
