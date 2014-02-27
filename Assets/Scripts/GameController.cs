using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject asteroid;

	void Start() {
		SpawnAsteroidWave ();
	}

	void SpawnAsteroidWave() {
		Vector3 astPosition = new Vector3 ();
		Quaternion astRotation = new Quaternion ();
		Instantiate (asteroid, astPosition, astRotation);
	}
}
