using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController))]
public class PlayerInput : MonoBehaviour {

	// set in inspector
	public float moveSpeed = 1;


	PlayerController controller;
	Camera mainCam;

	Utility utility;

	// Use this for initialization
	void Start () {

		controller = GetComponent<PlayerController>();
		mainCam = Camera.main;
		utility = Utility.instance;
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 moveVelocity = moveInput.normalized * moveSpeed;
		controller.move(moveVelocity);

		Ray ray = mainCam.ScreenPointToRay (Input.mousePosition);
		Plane grounPlain = new Plane (Vector3.up, Vector3.zero);
		float rayDistance;

		if (grounPlain.Raycast(ray, out rayDistance)) {
			Vector3 point = ray.GetPoint(rayDistance);

			if (utility.isDebuging)
				Debug.DrawLine(ray.origin, point, Color.red);

			controller.LookAt (point);
		}

	}
}
