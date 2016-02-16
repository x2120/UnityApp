using UnityEngine;
using System.Collections;

public class IgnoreColl : MonoBehaviour {

    public Transform Ignore;
    void Start()
    {
        Transform bullet = Instantiate(Ignore) as Transform;
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
    }
}

