using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP2 : MonoBehaviour
{

    public int maxHeath = 100;
    private int currentHealth2;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth2 = maxHeath;
    }

    public void Damage2(int damage2)
    {
        currentHealth2 -= damage2;

        if (currentHealth2 <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("player2 dood");
        this.enabled = false;
    }
}
