using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
         shoot();
       }  
    }
    void shoot()
    {
        Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
    }
}
