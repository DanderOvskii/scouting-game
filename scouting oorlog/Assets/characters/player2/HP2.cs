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
    public bool stun;
    public float stuntime = 2;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth2 = maxHeath;
        hpbar.helthbarUpdate(maxHeath, currentHealth2);
        stun = false;

    }

    public void Damage2(int damage2)
    {
        currentHealth2 -= damage2;
        hpbar.helthbarUpdate(maxHeath, currentHealth2);
        bloed.Play();
        stun = true;
        StartCoroutine(KnockbackStunTime(stuntime));

        if (currentHealth2 <= 0)
        {
            Die();
            
        }
    }

    IEnumerator KnockbackStunTime(float cooldown)
    {
        yield return new WaitForSeconds(cooldown);
        stun = false;
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
