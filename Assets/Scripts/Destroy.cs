using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    void OnTriggerEnter(Collider other){
        if (other.tag =="Boundary")
        {
            return;
        }

        if (other.tag == "EnemyShot")
        {
            return;
        }
            Destroy(other.gameObject);
            Destroy(gameObject);
        
    }
}
