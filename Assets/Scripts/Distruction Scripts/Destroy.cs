using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    void OnTriggerEnter(Collider other){
        //Object collider 


        /*if an Enemy Collides with another Enemy No interaction should occur (should pass through each other*/
        if (other.tag == "EnemyT 1")
        {
            return;
        }

        /*Enemy shots should only interact with the player, it should pass through all other objects*/
        if (other.tag == "Enemy_Shot")
        {
            return;
        }


        /*The player shot should destroy every thing it hits (exept the enemy shot?)*/
        if (other.tag == "shot")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }

    }
}
