using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPRefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            shoot();
        }
        Debug.Log("hallo wereld!");
    }

    void shoot()
    {
        Instantiate(bulletPRefab, firepoint.position, firepoint.rotation);
    }
}
