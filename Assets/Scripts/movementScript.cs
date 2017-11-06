using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {
		
	public float movementSpeed;// how fast will you run, set in  inspector
	public float jumpPower; // how high will you jump, set in  inspector
	public bool grounded;
	public GameObject shield;
	private Rigidbody2D rb2d;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();//getting the rigidbody from whatever the script is attached to
		//shield = GameObject.FindGameObjectWithTag("shield");
	}

	void FixedUpdate () {
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, transform.position.y);
		//rb2d.AddForce (movement * movementSpeed / Time.fixedDeltaTime);

		if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)) 
		{
			rb2d.AddForce (Vector2.left*movementSpeed);
		}
		if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)) 
		{
			rb2d.AddForce (Vector2.right*movementSpeed);
		}
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) && grounded== true)   {
			rb2d.AddForce (Vector2.up*jumpPower);
			grounded = false;
			
		}
		if (Input.GetKeyDown (KeyCode.E) || Input.GetKeyDown (KeyCode.RightShift)) {
			shield.SetActive (true);
		
		}
		if (Input.GetKeyUp(KeyCode.E)|| Input.GetKeyUp(KeyCode.RightShift)) {
			shield.SetActive (false);	
		}
	}
	void OnCollisionEnter2D (Collision2D other)//when player comes in contact with something 
	{
		if (other.gameObject.tag == "ground")// if player touch a object with the tag "Grounded", it will set the isGround and doubleJump to true
		{
			grounded= true;
		}
	}
}
