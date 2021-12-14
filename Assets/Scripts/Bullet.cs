using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public int damage;
    
   
    void Start()
    {
        rb.velocity = transform.right * speed;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerLife playerLife =  other.GetComponent<PlayerLife>();
        if( playerLife != null)
        {
            playerLife.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
