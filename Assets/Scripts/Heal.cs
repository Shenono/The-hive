using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public PlayerLife playerLife;
    public int variation;
    private void OnTriggerEnter(Collider other)
    {
        playerLife.Health += variation;
        Destroy(gameObject);
    }
}
