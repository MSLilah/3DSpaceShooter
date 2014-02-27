using UnityEngine;
using System.Collections;

public class AsteroidRotator : MonoBehaviour {
	public float tumble;
	void Start() {
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
