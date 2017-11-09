using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriigerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Is Hit!");
		
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2(2,1));
	
		}
	}
}
