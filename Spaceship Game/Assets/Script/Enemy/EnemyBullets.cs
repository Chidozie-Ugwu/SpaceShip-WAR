using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_timer = 3f;
    public Vector2 direction;
    public bool isEnemy = true;
    // Start is called before the first frame update
    private void OnEnable(){
        // Start the deactivation timer when the bullet is activated
        Invoke("Deactivate", deactivate_timer);
    }

    // Update is called once per frame
     private void OnDisable(){
    // Cancel the deactivation timer if the bullet is deactivated early
     CancelInvoke();

     }
     private void Update(){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
     }
     void Deactivate(){
        gameObject.SetActive(false);
     }
    
           private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
    
}
