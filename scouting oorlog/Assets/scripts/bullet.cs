using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int BulletDamage;
    public float RotationSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed + transform.up * speed;
       


    }

    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime *0, 0, RotationSpeed));
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
