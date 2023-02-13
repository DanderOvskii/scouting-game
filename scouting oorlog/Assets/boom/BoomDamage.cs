using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomDamage : MonoBehaviour
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
        if (other.gameObject.tag == "player2" && !attackExecuted)
        {
            attackExecuted = true;
            Attack();
            
        }
    }



    void Attack()
    {
        animator.SetTrigger("atack");
        Collider2D[] hitEnemies2 = Physics2D.OverlapBoxAll(attackPoint.position, transform.localScale * attackRange, 0, playerLayers);

        foreach (Collider2D enemy2 in hitEnemies2)
        {
            Debug.Log("ga spriggen ofzo");
            HP2 hp2 = enemy2.GetComponent<HP2>();
            if (hp2 != null)
            {
                hp2.Damage2(attackDamageBoom);
            }
            playermove2 pm2 = enemy2.GetComponent<playermove2>();
            if (pm2 != null)
            {
                pm2.jump = true;
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
