using UnityEngine;
using System.Collections;

public class PlayControler : MonoBehaviour {


	public float maxSpeed = 10.0f;
	public float jumpStrength = 400.0f;
	public Transform groundCheckPos;
	public LayerMask groundLayers;
	public float groundCheckRadius = 0.2f;
	
	public bool grounded = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate() {
	
	
		//Horizontal movement logic
		Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
		Vector2 newVelocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, velocity.y);
		
		GetComponent<Rigidbody2D>().velocity = newVelocity;
	
	
		grounded = Physics2D.OverlapCircle(groundCheckPos.position, groundCheckRadius, groundLayers);
	
		if(Input.GetAxis("Jump") > 0 && grounded) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpStrength));
		}
	}
}
