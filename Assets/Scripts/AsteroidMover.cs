using UnityEngine;
using System.Collections;

public class AsteroidMover : MonoBehaviour {
	public int speed;
	void Start() {
		//Get the direction of movement
		Vector3 direction = new Vector3 (-transform.position.x, 0, -(transform.position.z + 10));
		direction /= GameController.distance;

		rigidbody.velocity = direction * speed;
	}
}
