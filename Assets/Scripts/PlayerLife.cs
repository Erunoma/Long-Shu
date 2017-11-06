using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

	public int life;
	public bool immune;
	public int immuneTime;
	public float knockBack;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (life <= 0) {
			InitGameOver ();
		}
	}

	public void InitGameOver(){
		
	}


	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Damage" && immune == false) {
			Debug.Log ("Is Hit!");
			life -= 1;
			gameObject.GetComponent<Rigidbody2D> ().AddForce (gameObject.GetComponent<Transform> ().transform.forward * Time.deltaTime);
			InitImmune ();
		}
	}

	public void InitImmune(){
		immune = true;
		StartCoroutine (PlayerImmuneTimer ());
	}

	IEnumerator PlayerImmuneTimer(){
		yield return new WaitForSeconds (immuneTime);
		immune = false;
	}
}
