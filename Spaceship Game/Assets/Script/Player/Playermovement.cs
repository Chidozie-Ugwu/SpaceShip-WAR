using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public float speed = 5.0f;
    public float min_Y, max_Y;
    public float min_X, max_X;

    void Update()
    {
    MovePlayer();

    
            if(true){
            Debug.Log("Works");
        }

            if(Input.GetKey(KeyCode.A)){
            Debug.Log("Works");
        }
    }

    
    void MovePlayer()
    {


      Vector3 temp = transform.position;

      if(Input.GetKey(KeyCode.UpArrow)){
        temp.y += speed * Time.deltaTime;
        if(temp.y > max_Y)
        temp.y = max_Y;
      }
      else if( Input.GetKey(KeyCode.DownArrow)){
        temp.y -= speed* Time.deltaTime;
        if(temp.y < min_Y)
           temp.y = min_Y;

      }
      if(Input.GetKey(KeyCode.RightArrow)){
        temp.x += speed * Time.deltaTime;
        if(temp.x > max_X)
           temp.x = max_X;
      }
      else if(Input.GetKey(KeyCode.LeftArrow)){
        temp.x -= speed * Time.deltaTime;
        if (temp.x <  min_X)
          temp.x = min_X;
      }
      transform.position = temp;
    }

}
