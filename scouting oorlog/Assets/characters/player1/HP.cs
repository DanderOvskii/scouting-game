using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{

    public int maxHeath = 100;
    private int currentHealth;
    public GameObject player;
    [SerializeField] private heathbarscript hpbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHeath;
        hpbar.helthbarUpdate(maxHeath, currentHealth);
    }

   public void Damage(int damage)
    {
        currentHealth -= damage;
        hpbar.helthbarUpdate(maxHeath, currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
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
