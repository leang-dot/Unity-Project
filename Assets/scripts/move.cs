using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + X, transform.position.y + Y, transform.position.z + Z);
        

    }
}
