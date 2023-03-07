using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP2 : MonoBehaviour
{

    public int maxHeath = 100;
    private int currentHealth2;
    public GameObject player;
    [SerializeField] private heathbarscript2 hpbar;
    public ParticleSystem bloed;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth2 = maxHeath;
        hpbar.helthbarUpdate(maxHeath, currentHealth2);

    }

    public void Damage2(int damage2)
    {
        currentHealth2 -= damage2;
        hpbar.helthbarUpdate(maxHeath, currentHealth2);
        bloed.Play();

        if (currentHealth2 <= 0)
        {
            Die();
            
        }
    }

    public void hpplus2(int plus2)
    {
        currentHealth2 += plus2;
        
        hpbar.helthbarUpdate(maxHeath, currentHealth2);
    }

    void Die()
    {
        Debug.Log("player2 dood");
        this.enabled = false;
        player.SetActive(false);
    }
}
