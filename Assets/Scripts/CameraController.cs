using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		float xAxis = Input.GetAxis ("Horizontal");

		bool boundsCheck = Mathf.Abs (transform.rotation.y) < 0.25;
		boundsCheck = boundsCheck || (transform.rotation.y > 0.25 && xAxis < 0);
		boundsCheck = boundsCheck || (transform.rotation.y < -0.25 && xAxis > 0);

		if (boundsCheck) {
			transform.Rotate (new Vector3 (0.0f, xAxis, 0.0f));
		}
	}
}
