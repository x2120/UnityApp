using UnityEngine;
using System.Collections;

public class DestroyBound : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //if An Object Hits the Boundary then the object is destoryed 
        if (other.tag == "boundary")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }

    }
}

