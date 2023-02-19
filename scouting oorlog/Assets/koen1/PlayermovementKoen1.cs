using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayermovementKoen1 : MonoBehaviour
{
    public CharacterController2Dkoen1 controler;
    public Animator animator;
    public  Rigidbody2D rigidBody; 

    public float runSpeed = 40f;
    
   public bool jump = false;
    bool crouch = false;







    float horizontalMove = 0f;
    // Update is called once per frame
    void Update(){

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs (horizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            controler.doeblejump = true;
            controler.jumpcount++;
           
        }
        if (Input.GetButtonDown("Crouch"))
        {
        crouch = true;


        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetKeyDown("s") ){
             rigidBody.gravityScale = 10;
        }

    }

    public void OnLandingkoen1 () 
    {
        animator.SetBool("IsJumping", false);
        rigidBody.gravityScale = 3;
        jump = false;
        controler.jumpcount = 0;
        controler.doeblejump = false;
       
        Debug.Log("boeia");
    }

    public void Oncrouchungkoen1 (bool ischouching)

    {
        animator.SetBool("iscrouching",ischouching);

    }



    void FixedUpdate ()
    {
        controler.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        
    }


}
