using UnityEngine;
using System.Collections;

public class AsteroidCollider : MonoBehaviour {

	public GameObject asteroidExplosion;

	void OnTriggerEnter(Collider other) {
		Instantiate (asteroidExplosion, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
