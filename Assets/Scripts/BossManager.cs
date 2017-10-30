using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossManager : MonoBehaviour {

	public float health;
	public int str;
	public GameObject cloud;
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
		
	}

	public void InitBoss(){
		phase = 1;
		activeAbility = 1;
	}
}
