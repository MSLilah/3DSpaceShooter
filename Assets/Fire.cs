using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public GameObject shot;
	public float fireRate;
	public Transform shotSpawn;
	private float nextFire;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}
