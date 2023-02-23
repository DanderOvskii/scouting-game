using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatiescript : MonoBehaviour
{
   
    public Animator animator;
    

 







    float horizontalMove = 0f;
    // Update is called once per frame
    void Update()
    {


        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            
            animator.SetBool("IsJumping", true);
         

        }
       

    }
}
