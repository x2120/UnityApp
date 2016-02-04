using UnityEngine;
using System.Collections;

[System.Serializable]
public class boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class playerControl : MonoBehaviour
{
	public float speed;
	public boundary gameMap;

	// public GameObject shot;
	// public Transform shotSpawn;
	// public float fireRate;

	// private float nextFire;

	void Update()
	{
		/*
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
		*/
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxisRaw("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;

		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp(GetComponent<Rigidbody>().position.x, gameMap.xMin, gameMap.xMax),
			0.0f,
			Mathf.Clamp(GetComponent<Rigidbody>().position.z, gameMap.yMin, gameMap.yMax)
		);
	}
}