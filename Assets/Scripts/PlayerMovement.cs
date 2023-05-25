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
    public AudioSource footstepsound;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        footstepsound = GameObject.Find("FootAudio").GetComponent<AudioSource>();

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ){
            footstepsound.enabled = true;
        }
        else{
            footstepsound.enabled = false;
        }
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
