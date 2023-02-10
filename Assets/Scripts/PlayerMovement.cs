using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     //variables
    public float moveSpeed;

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //move input
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        if (moveDirection != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("directX", moveDirection.x);
            anim.SetFloat("directY", moveDirection.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        
        if(DialogueManager.GetInstance().dialogueIsPlaying){
            return;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection.normalized * moveSpeed;
    }


}
