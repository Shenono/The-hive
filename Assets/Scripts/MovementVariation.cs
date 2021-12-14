using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementVariation : MonoBehaviour
{
    public Movement movement;
    public float variation;
    private void OnTriggerEnter(Collider other)
    {
        movement.moveSpeed += variation;
        Destroy(gameObject);
    }
}
