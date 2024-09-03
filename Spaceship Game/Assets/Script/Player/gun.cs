using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
         Shoot();
       }  
    }
    void Shoot()
    {
        Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
    }
}
