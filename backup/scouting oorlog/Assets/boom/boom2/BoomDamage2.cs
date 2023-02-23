using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomDamage2 : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    public int attackDamageBoom;
    private bool attackExecuted = false;





    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.gameObject.tag == "player1" && !attackExecuted)
        {
            attackExecuted = true;
            Attack();
            
        }
    }



    void Attack()
    {
        animator.SetTrigger("atack");
        Collider2D[] hitEnemies = Physics2D.OverlapBoxAll(attackPoint.position, transform.localScale * attackRange, 0, playerLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("ga spriggen ofzo");
            HP hp = enemy.GetComponent<HP>();
            if (hp != null)
            {
                hp.Damage(attackDamageBoom);
            }
            playermovement pm = enemy.GetComponent<playermovement>();
            if (pm != null)
            {
                pm.jump = true;
            }


        }

    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireCube(attackPoint.position, transform.localScale*attackRange);
    }

    void die()
    {
        Destroy(this);
    }
}
