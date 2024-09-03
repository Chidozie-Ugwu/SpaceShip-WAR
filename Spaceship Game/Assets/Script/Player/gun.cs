using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioSource[] soundFX;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
         Shoot();
         soundFX[0].Play();
       }  
    }
    void Shoot()
    {
        Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
    }

}
