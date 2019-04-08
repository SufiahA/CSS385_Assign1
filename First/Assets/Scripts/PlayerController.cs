using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	private Rigidbody rb;
	public int Speed;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	// Check for input and apply force
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal * Speed, 0.0f, moveVertical * Speed);
		rb.AddForce(movement);
	}
}
