using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int BulletDamage;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP2 hp= collision.GetComponent<HP2>();
        if(hp != null)
        {
            hp.Damage2(BulletDamage);
        }
        Destroy(gameObject);
    }

}
