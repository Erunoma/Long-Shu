using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDeflect : MonoBehaviour {

	public GameObject boss;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "shield")
		{
			boss.GetComponent<BossOrb> ().launching = false;
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (boss.transform.position.x, boss.transform.position.y));
			Debug.Log ("Hit Shield!");
		}
		/*
		if (other.gameObject.tag == "Player")
		{
			player.GetComponent<PlayerLife> ().life--;
			Destroy (gameObject);
		}
*/
	}
}
