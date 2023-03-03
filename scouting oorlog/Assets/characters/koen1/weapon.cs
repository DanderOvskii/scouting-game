using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPRefab;
    public float attacktime = 2f;
    float ready = 0f;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
       
            if (Time.time >= ready&&Input.GetKeyDown(KeyCode.E))
            {

                Invoke("shoot", 0.5f);
                animator.SetTrigger("supperataack");
                ready = Time.time + 1f / attacktime;
            }
        
        
=======
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            Invoke("shoot", 1);
            animator.SetTrigger("supperataack");
            ready = Time.time + 1f / attacktime;
        }
        Debug.Log("hallo wereld!");
>>>>>>> parent of c7f62c0 (ja)
    }

    void shoot()
    {
        Instantiate(bulletPRefab, firepoint.position, firepoint.rotation);
    }
}
