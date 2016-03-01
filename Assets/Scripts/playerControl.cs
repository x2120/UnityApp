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
	private float xStart = 0;
	private float zStart = 0;

	void Start()
	{
		xStart = Input.acceleration.x;
		zStart = Input.acceleration.z;
	}

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
		float moveHorizontal = Input.acceleration.x;
		float moveVertical = -Input.acceleration.z;

		Vector3 movement = new Vector3 (moveHorizontal-xStart, 0.0f, moveVertical-zStart);
		GetComponent<Rigidbody>().velocity = movement * speed;

		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp(GetComponent<Rigidbody>().position.x, gameMap.xMin, gameMap.xMax),
			0.0f,
			Mathf.Clamp(GetComponent<Rigidbody>().position.z, gameMap.yMin, gameMap.yMax)
		);
	}
}