using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f;

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}