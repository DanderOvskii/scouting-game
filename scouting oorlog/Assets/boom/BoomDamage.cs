using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomDamage : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    public int attackDamageBoom = 200;




    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.gameObject.tag == "player2")
        {
            Attack();
            
        }
    }



    void Attack()
    {
        animator.SetTrigger("atack");
        Collider2D[] hitEnemies2 = Physics2D.OverlapBoxAll(attackPoint.position, transform.localScale * attackRange, 0, playerLayers);

        foreach (Collider2D enemy2 in hitEnemies2)
        {
            enemy2.GetComponent<HP2>().Damage2(attackDamageBoom);
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
