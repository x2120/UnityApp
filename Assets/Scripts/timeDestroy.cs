using UnityEngine;
using System.Collections;

public class timeDestroy : MonoBehaviour
{
	private int timer = 0;

	void Update()
	{
		if (timer < 130)
		{
			timer++;
		}
		else
		{
			Destroy(gameObject);
		}
	}
}