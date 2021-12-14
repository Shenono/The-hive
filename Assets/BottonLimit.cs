using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonLimit : MonoBehaviour
{
    public PlayerLife playerLife;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerLife.Health = 0;
        }
    }
}
