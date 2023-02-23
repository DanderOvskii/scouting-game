using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercombat2 : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    public int attackDamage = 40;
    public float attacrate = 2f;
    float nextattack = 0f;
    



    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextattack)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Attack();
                nextattack = Time.time + 1f / attacrate;
                
            }
        }

    }

    void Attack()
    {
        animator.SetTrigger("atack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            HP hp = enemy.GetComponent<HP>();
            if (hp != null)
            {
                hp.Damage(attackDamage);
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
