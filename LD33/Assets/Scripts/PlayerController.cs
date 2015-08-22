using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public int walkSpeed;
	private bool grounded = false;

	// Use this for initialization
	void Start () {
	 // add animator here
	}
	
	void FixedUpdate () {
		if ((Input.GetKey("up") || Input.GetKey("space")) && grounded) {
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));
			grounded = false;
		}
		else if (Input.GetKey("right")) {
			transform.Translate(Vector3.right * walkSpeed * Time.deltaTime);
		}
		else if (Input.GetKey("left")) {
			transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name == "Ground") {
			grounded = true;
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == "Person") {
			print("person");
		}
	}
}
