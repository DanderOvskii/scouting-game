using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperStickman : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2;
    [SerializeField] float jumpForce = 0;

    PauseSystem pauseSystem;
    Rigidbody2D rb2;
    Animator anm;

    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        anm = GetComponent<Animator>();
        pauseSystem = FindObjectOfType<PauseSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseSystem.GetIsPaused()) { return; }

        if (Input.GetKeyDown(KeyCode.J))
        {
            anm.SetTrigger("Super");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2.AddForce(Vector2.up * jumpForce);
        }

        Vector2 newVelocity = rb2.velocity;
        newVelocity.x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        rb2.velocity = newVelocity;
    }
}
