using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public GameObject explosionPrefab;
        [SerializeField] private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
      //Intialize player health
      currentHealth = maxHealth;  
    }

    // Update is called once per frame
    public void TakeDamage(int damage){
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
            GameOver();
        } 
    }
    void Die()
    {
       Explode();
        // Add logic for the player health, e.g, play death animation, show game over screen
        Debug.Log("Player Died");
        Destroy(gameObject);// Destroy the playerGameObject
    }
     private void OnTriggerEnter2D(Collider2D collision){
        //Check if the collision object is an enemy bullet
         EnemyBullets bullet = collision.GetComponent<EnemyBullets>();
    if (bullet != null && bullet.isEnemy)
    {
        TakeDamage(1);//Assume each bullet does 1 Dmg
        Destroy(bullet.gameObject);//destroy the bullet
    }
     }

      void GameOver()
    {
        Time.timeScale = 0; // Stops the game
         //gameOverPanel.SetActive(true);
    }
     private void OnCollisionEnter2D(Collision2D collision)
     {
        //CHECK IF THE PLAYER COLLIDED WITH AN ENEMY
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();//Player dies instanlty on contact with the enemy
            GameOver();
        }
     }

      void Explode()
      {
        Debug.Log("Explode method called");
        GameObject explosion = Instantiate(explosionPrefab,transform.position, transform.rotation);
        Destroy(explosion ,1f);
      }
  
}
