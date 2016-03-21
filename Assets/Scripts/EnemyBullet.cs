﻿using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    Vector2 _direction;
    bool isReady;

    void Awake()
    {
        isReady = false;
    }

    // Use this for initialization
    void Start()
    {

    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction.normalized;

        isReady = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (isReady)
        {
            Vector2 position = transform.position;

            position += _direction * speed * Time.deltaTime;
            transform.position = position;


            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));


            if ((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.x < min.y) || (transform.position.x > max.y))
            {
                Destroy(gameObject);
            }

        }


    }
}
