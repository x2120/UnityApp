using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    void OnTriggerEnter(Collider other){
        //only if the object hits the boundary it deletes it


        if (other.tag == "boundary")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }

        //enemy objects dont interact with each other (but they should not collide regardless
        if (other.tag == "Enemy")
        {

            return;
        }

        //if the bullet hits an object then the object should be destroyed
        if (other.tag == "Shot")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }


        ////back up boundary??? (has to be capsed or does not work???
        //if (other.tag == "Boundary")
        //{

        //    return;
        //}
        /*trying to get enemy shots not to interact with each other and have only player shots interact*/
        //Destroy(other.gameObject);
        //Destroy(gameObject);

    }
}
