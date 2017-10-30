using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {
		
	public float movementSpeed;// how fast will you run, set in  inspector
	public float jumpPower; // how high will you jump, set in  inspector
	public bool grounded;
	private Rigidbody2D rb2d;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();//getting the rigidbody from whatever the script is attached to
	}

	void FixedUpdate () {
		//float moveVertical = Input.GetAxis ("Vertical");
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, 0);
		Vector2 direction = transform.position;

		rb2d.MovePosition(rb2d.position + movement*movementSpeed*Time.fixedDeltaTime);

		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) && grounded)   {
			rb2d.AddForce (Vector2.up*jumpPower);
			grounded = false;
			
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
