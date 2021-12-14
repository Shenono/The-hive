using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBooster : MonoBehaviour
{
    public Movement movement;
    public float variation;
    private void OnTriggerEnter(Collider other)
    {
        movement.jumpForce += variation;
        Destroy(gameObject);
    }
}
