using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnXOffset = 10f;
    public float moveSpeed = 5f;
    public float minY = -4f;
    public float maxY = 4f;
    // Start is called before the first frame update
  private float timeSinceLastSpawn  = 0f;

    // Update is called once per frame
    void Update()
    {
       timeSinceLastSpawn += Time.deltaTime;
       if (timeSinceLastSpawn >= spawnInterval)
       {
         spawnEnemy();
         timeSinceLastSpawn = 0f;
       }  
    }
    void spawnEnemy(){
        // Randomize the y position within a specified range
        float spawnY = Random.Range(minY,maxY);
        // Set the x position to the  right side of the off screen
        float spawnX =  Camera.main.transform.position.x + spawnXOffset;
        // Create the spawn position vector
        Vector2 spawnPosition = new Vector2(spawnX,spawnY);
        //Instantiate the enemy at the spawn position
        GameObject enemy =  Instantiate(enemyPrefab, spawnPosition ,  Quaternion.identity);
        // move the enemy left by applying velocity directly
        Rigidbody2D enemyRb =  enemy.GetComponent<Rigidbody2D>();
        if (enemyRb != null)
        {
            enemyRb.velocity = Vector2.left * moveSpeed;
        }
    }
}

