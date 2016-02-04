using UnityEngine;
using System.Collections;

public class shotMove : MonoBehaviour
{
    public float speed;

	void Start()
	{
        Vector3 movement = new Vector3(1.0f, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;
    }
}
