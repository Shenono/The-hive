using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int Health= 100;
    public float DeathTime;
    public Animator animator;
    public Movement movement;
    public Looking looking;
    public void TakeDamage(int Damage)
    {
        Health -= Damage;
     
    }
    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Destroy(looking);
            movement.moveSpeed = 0;
            movement.jumpForce = 0;
            DeathTime -= Time.deltaTime;
            animator.SetBool("Dead", true);
        }
        if(DeathTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
