using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightningStrike : MonoBehaviour {

	public Animator anim;
	public int damage;
	public int waitTime;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void InitLightning(){
		int randLightning = Random.Range (0, 2);
		if (randLightning == 0) {
			anim.SetBool ("SideLightningUp", true);
		}
		if (randLightning == 1) {
			anim.SetBool ("SideLightningDown", true);
		}
		StartCoroutine (SkyLightning ());
	}

	IEnumerator SkyLightning(){
		yield return new WaitForSeconds (waitTime);
		anim.SetBool ("SideLightningUp", false);
		anim.SetBool ("SideLightningDown", false);
		anim.SetBool ("SkyLightning", true);
		StartCoroutine (DisableLightning ());

	}
	IEnumerator DisableLightning(){
		yield return new WaitForSeconds (4);
		anim.SetBool ("SkyLightning", false);

}
}