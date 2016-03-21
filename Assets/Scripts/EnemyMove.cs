using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    float frequency = 0.3f;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        Vector3 movement = new Vector3(1.0f, 0.0f, 1.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;
    }

    void Update()
    {
        //for ship movement using math formauls 
        //here we need to update the z of the bullet so we can generate patterns
        //transform.(up,down,left,right,foward,backward) moves in that positions
        pos += transform.right * Time.deltaTime * speed;
        transform.position = pos ;
    }//to do waves * Mathf.Cos(Time.time) * frequency
}
