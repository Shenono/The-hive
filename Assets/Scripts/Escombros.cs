using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escombros : MonoBehaviour
{
    public Rigidbody rigidbody;
    public void OnTriggerEnter(Collider other)
    {
        rigidbody.useGravity = true;
    }
}
