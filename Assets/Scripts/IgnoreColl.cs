using UnityEngine;
using System.Collections;

public class IgnoreColl : MonoBehaviour {

    public Transform bulletPrefab;
    void Start()
    {
        Transform bullet = Instantiate(bulletPrefab) as Transform;
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
    }
}

