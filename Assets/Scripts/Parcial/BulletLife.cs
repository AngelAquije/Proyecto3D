using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    public float life = 5;

    void Awake()
    {
        Destroy(gameObject, life);        
    }

    
}