using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomspawner2 : MonoBehaviour
{
    public GameObject Boom;
    public float attacktime = 2f;
    float ready = 0f;
    public Animator animator;
    



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= ready)
        {

if (Input.GetKey(KeyCode.L))
        {

                Invoke("Spawn", 1);
                animator.SetTrigger("supperataack");
                ready = Time.time + 1f / attacktime;
        }
        }
            

    }

    void Spawn()
    {
        GameObject clone =  Instantiate(Boom, transform.position, Quaternion.identity);
        Destroy(clone, 2.0f);
    }
}
