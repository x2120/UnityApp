using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    Vector3 _direction;
    bool isReady;

    void Awake()
    {
        isReady = false;
    }

    // Use this for initialization
	void Start()
	{
        Vector3 movement = new Vector3(1.0f, 0.0f, 1.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction.normalized;

        isReady = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (isReady)
        {
            Vector3 position = transform.position;

            position += _direction * speed * Time.deltaTime;
            transform.position = position;


            Vector3 min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
            Vector3 max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 1));


            if ((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.x < min.y) || (transform.position.x > max.y))
            {
                Destroy(gameObject);
            }

        }


    }
}
