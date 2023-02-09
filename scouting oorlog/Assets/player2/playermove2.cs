using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove2 : MonoBehaviour
{
    public CharacterController2D controler;
    public Animator animator;
    public Rigidbody2D rigidBody;

    public float runSpeed = 40f;

    public bool jump = false;
    bool crouch = false;




    float horizontalMove = 0f;
    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("arrows") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("arrowup"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);

        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;


        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetKeyDown("s"))
        {
            rigidBody.gravityScale = 10;
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        rigidBody.gravityScale = 3;
        jump = false;

    }

    public void Oncrouchung(bool ischouching)

    {
        animator.SetBool("iscrouching", ischouching);

    }



    void FixedUpdate()
    {
        controler.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

    }

}
