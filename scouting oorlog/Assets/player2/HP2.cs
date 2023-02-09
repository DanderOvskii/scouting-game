using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP2 : MonoBehaviour
{

    public int maxHeath = 100;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHeath;
    }

    public void Damage2(int damage2)
    {
        currentHealth -= damage2;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("ja die is dood");
        this.enabled = false;
    }
}
