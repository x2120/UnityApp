using UnityEngine;
using System.Collections;

public class IgnoreColl : MonoBehaviour {
    public GameObject EnemyT;
    void Start() {
        GameObject Enemy = Instantiate(EnemyT);
        Physics.IgnoreCollision(Enemy.GetComponent<Collider>(), Enemy.GetComponent<Collider>());
    }
}