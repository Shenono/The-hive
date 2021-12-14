using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce; 
    bool isGrounded = true;
    private Rigidbody pRigidBody;
    public Animator animator;
    void Start()
    {
        pRigidBody = GetComponent<Rigidbody>();
        animator.SetFloat("Speed", 0);
    }
    void Update()
    {
        pRigidBody.freezeRotation = true;
        Jump();
       
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * moveSpeed;
            
        if (Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Horizontal") > 0)
        {
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
     
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            pRigidBody.AddForce(new Vector3(0, jumpForce, 0));
           
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpForce,0f), ForceMode.Impulse);
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        }
    }
    void OnCollisionStay(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetFloat("Jump", 0);
        }
    }
    void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetFloat("Jump", 1);
        }
    }
}
