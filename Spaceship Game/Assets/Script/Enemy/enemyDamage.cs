using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    // Start is called before the first frame update
       public int health = 1;
       public GameObject explosionPrefab;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }
     void TakeDamage(int damage){
        health -= damage;
        if (health<=0)
        {
            Die();
        }
     }
     private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.gameObject.CompareTag("Player"))
        {
            Die();
        }
     }
     void Die()
     {
        Destroy(gameObject);
        Explode();
     }
      void Explode()
      {
        GameObject explosion = Instantiate(explosionPrefab,transform.position, transform.rotation);
        Destroy(explosion ,1f);
      }
}
