using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heathupgrate : MonoBehaviour
{

    public Rigidbody2D rb;
    public int Plus;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP hp = collision.GetComponent<HP>();
        HP2 hp2 = collision.GetComponent<HP2>();

        if (hp2 == true)
        {
            hp2.hpplus2(Plus);
        }
       else if (hp ==true)
        {
            hp.hpplus(Plus);
        }
        
    }

}

