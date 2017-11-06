using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOrb : MonoBehaviour {

	public GameObject orbTemp;
	public GameObject currentOrb;
	//public Animator orbAnim;
	public int waitTimer;
	public GameObject player;

	public Vector2 targetPos;
	public Vector2 startPos;
	public int timeToTarget;
	public bool launching;
	public bool growing;
	public float t;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (launching == true) {
			currentOrb.transform.position += new Vector3(targetPos.x,targetPos.y,0) / 20;
		}
		if (growing == true) {
			currentOrb.GetComponent<Transform> ().localScale += new Vector3 (0.1F, 0.1F, 0.1F) * Time.deltaTime;
		}
	}


	public void InitOrb(){
		currentOrb = Instantiate (orbTemp, new Vector2 (4.6F, 1.44F), Quaternion.identity);
		growing = true;

		startPos = currentOrb.transform.position;
		StartCoroutine (LaunchOrb ());
	}

	IEnumerator LaunchOrb(){
		yield return new WaitForSeconds (waitTimer);
		growing = false;
		targetPos = player.transform.position;
		launching = true;
		StartCoroutine (NextAttack ());
	}

	IEnumerator NextAttack(){
		yield return new WaitForSeconds (8);
		launching = false;
		gameObject.GetComponent<BossManager> ().NextAttack ();
	}
}
