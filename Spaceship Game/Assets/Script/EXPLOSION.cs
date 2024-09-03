using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPLOSION : MonoBehaviour
{ 
    public float lifetime = 1.0f;
    // Start is called before the first frame update
     void ExplosionDone(){
        Destroy(gameObject, lifetime);
     }
}
