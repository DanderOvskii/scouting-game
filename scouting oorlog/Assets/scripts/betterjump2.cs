using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterjump2 : MonoBehaviour
{

    public float fall = 2.5f;
    public float low = 2f;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fall - 1)*Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetButton("arrowup")){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (low - 1) * Time.deltaTime;
        }
        
    }
}
