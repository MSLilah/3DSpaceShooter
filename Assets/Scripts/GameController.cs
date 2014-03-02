using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject asteroid;
	public Vector3 astSpawnValues;
	public static int distance = 60;
	public float startWait;
	public float spawnWait;
	public float waveWait;
	private int numAsteroids = 3;
	private int waveNum = 0;
	public const int wavesBeforeIncrease = 3;
	private bool startWave = true;

	void Start() {
		StartCoroutine(SpawnAsteroidWave ());
	}

	IEnumerator SpawnAsteroidWave() {
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < numAsteroids; i++) {
				float x = Random.Range(-1, 1) * distance;
				float z = Mathf.Sqrt (Mathf.Pow (distance, 2) - Mathf.Pow (x, 2));
				float randomCheck = Random.value;
				if (randomCheck > 0.5) {
					z *= -1;
				}
				Vector3 astPosition = new Vector3 (x, 1, z - 10);
				Quaternion astRotation = Quaternion.identity;
				Instantiate (asteroid, astPosition, astRotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
			waveNum++;
			if (waveNum > wavesBeforeIncrease) {
				numAsteroids++;
				waveNum = 0;
			}
		}
	}
}

