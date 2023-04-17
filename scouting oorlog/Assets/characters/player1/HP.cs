using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{

    public int maxHeath = 100;
    private int currentHealth;
    public GameObject player;
    [SerializeField] private heathbarscript hpbar;
    public ParticleSystem bloed;
    public bool stun;
    public float stuntime = 2;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHeath;
        hpbar.helthbarUpdate(maxHeath, currentHealth);
        stun = false;
    }

   public void Damage(int damage)
    {
        currentHealth -= damage;
        hpbar.helthbarUpdate(maxHeath, currentHealth);
        bloed.Play();
        stun = true;
        StartCoroutine(KnockbackStunTime(stuntime));


        if (currentHealth <= 0)
        {
            Die();
        }
    }
    IEnumerator KnockbackStunTime(float cooldown)
    {
        yield return new WaitForSeconds(cooldown);
        stun = false;
    }
    public void hpplus(int plus)
    {
        currentHealth += plus;
        
        hpbar.helthbarUpdate(maxHeath, currentHealth);
    }

    void Die()
    {
        Debug.Log("player1 dood");
        this.enabled = false;
        player.SetActive(false);
    }
}
