using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

	Vector3 velocity;

	Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
	}
	
	public void move (Vector3 _velocity) {
		velocity = _velocity;
	}

	public void LookAt (Vector3 lookPoint) {
		transform.LookAt (lookPoint);
	}

	void FixedUpdate () {
		myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);
	}
}
