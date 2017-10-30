using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossManager : MonoBehaviour {

	public float health;
	public int str;
	public GameObject cloud;
	public GameObject lightning;
	public Animator anim;
	public int phase;

	public int activeAbility;
	public int cooldown;

	// Use this for initialization
	void Start () {
		health = 100;
		InitBoss ();
	}
	
	// Update is called once per frame
	void Update () {
		if (phase == 2) {
			lightning.GetComponent<LightningStrike> ().waitTime = 2;
		}
		if (phase == 2) {
			lightning.GetComponent<LightningStrike> ().waitTime = 1;
		}
	}

	public void InitBoss(){
		phase = 1;
		activeAbility = 1;
		lightning.GetComponent<LightningStrike> ().InitLightning ();
	}
}
