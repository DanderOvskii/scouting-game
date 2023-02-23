using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercombat : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    public int attackDamage2 = 40;
    public float attacrate = 2f;
    float nextattack = 0f;

         

 
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextattack)
        {
         if (Input.GetKeyDown(KeyCode.F))
            {
                Attack();
                nextattack = Time.time + 1f / attacrate;
            }
        }
       
    }

    void Attack()
    {
        animator.SetTrigger("atack");
        Collider2D[] hitEnemies2 = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach(Collider2D enemy2 in hitEnemies2)
        {
            HP2 hp2 = enemy2.GetComponent<HP2>();
            if (hp2 != null)
            {
                hp2.Damage2(attackDamage2);
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}
