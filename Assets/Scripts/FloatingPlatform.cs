using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatform : MonoBehaviour {

	public Transform target;
	public Transform[] stops;
	public int number;
	public float step;
	// Use this for initialization
	void Start () {
		target = stops[0];
		number = 0;
	}
	
	// Update is called once per frame
	void Update () {
			transform.position = Vector2.MoveTowards (transform.position, target.transform.position, step);

		if (Vector2.Distance(transform.position,target.position)<0.5f){
			number++;
			number %= stops.Length;
			target = stops [number];
		}

	}
}
