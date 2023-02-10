using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomspawner : MonoBehaviour
{
    public GameObject Boom;
    public float attacktime = 2f;
    float ready = 0f;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= ready)
        {

if (Input.GetKey(KeyCode.Return))
        {
            Spawn();
                ready = Time.time + 1f / attacktime;
        }
        }
            

    }

    void Spawn()
    {
        Instantiate(Boom, transform.position, Quaternion.identity);
    }
}
