using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject asteroid;
	public Vector3 astSpawnValues;
	public static int distance = 60;

	void Start() {
		SpawnAsteroidWave ();
	}

	void SpawnAsteroidWave() {
		float x = Random.value * distance;
		float z = Mathf.Sqrt (Mathf.Pow (distance, 2) - Mathf.Pow (x, 2));
		Vector3 astPosition = new Vector3 (x, 1, z - 10);
		Quaternion astRotation = Quaternion.identity;
		Instantiate (asteroid, astPosition, astRotation);
	}
}
