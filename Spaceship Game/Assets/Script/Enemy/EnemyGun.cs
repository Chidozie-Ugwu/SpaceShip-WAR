using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject bulletPrefab; //The bullet prefab to instantiate
    public Transform firePoint;//The point from where the bullet is fired
    public float shootingInterval = 2f;// Time between shots
    private float shootingTimer;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        // INCREMENT THE TIMER
        shootingTimer += Time.deltaTime;
        //SHOOT WHEN THE TIMER REACHES THE INTERVAL
        if (shootingTimer >= shootingInterval)
        {
            shoot();
            shootingTimer = 0f;
        }
    }
    void shoot(){
        Instantiate(bulletPrefab, firePoint.position , firePoint.rotation);
    }
}
