using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM : MonoBehaviour
{
   public float moveSpeed =  5f;

    void Update()
    {
       float moveX = Input.GetAxis("Horizontal");
       float moveY = Input.GetAxis("Vertical");

       Vector3 movement = new Vector3(moveX, moveY, 0f)* moveSpeed *Time.deltaTime;

       transform.Translate(movement);
    }
}
