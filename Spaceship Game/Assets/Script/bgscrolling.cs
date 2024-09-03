using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgscrolling : MonoBehaviour
{
    public float backgroundSpeed = 0.1f; //speed at which the background moves
    public Renderer backgroundRenderer; 
    
        
    

    // Update is called once per frame
    void Update()
    {
        //Calculate the offset for the texture
         float offset = Time.time * backgroundSpeed;
        // Apply the offset to the texture
         backgroundRenderer.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
