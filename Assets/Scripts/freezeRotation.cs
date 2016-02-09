using UnityEngine;
using System.Collections;

public class freezeRotation : MonoBehaviour
{
    public RigidbodyConstraints constraints;

    void Start()
    {
        constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }
}





