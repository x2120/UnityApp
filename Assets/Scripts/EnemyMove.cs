using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        Vector3 movement = new Vector3(1.0f, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;
    }

    void Update()
    {
        //for ship movement using math formauls 
        //here we need to update the z of the bullet so we can generate patterns
        pos += transform.right * Time.deltaTime * speed;
        transform.position = pos * Mathf.Sin(Time.time);
    }
}
