using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMUSIC : MonoBehaviour
{ 
    private static BGMUSIC backgroundMusic;
    // Start is called before the first frame update
void Awake(){
    if (backgroundMusic == null)
    {
      backgroundMusic = this;
      DontDestroyOnLoad(backgroundMusic);   
    }
    else
    {
        Destroy(gameObject);
    }
}
}
