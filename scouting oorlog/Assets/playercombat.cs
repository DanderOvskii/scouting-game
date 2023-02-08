using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercombat : MonoBehaviour
{

    public Animator animator;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("atack");
    }
}
