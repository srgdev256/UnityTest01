using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using Random = UnityEngine.Random;

public class RandomStartSize : MonoBehaviour
{
    [SerializeField] 
    private float _sizeMin = 0.1f;
    
    [SerializeField] 
    private float _sizeMax = 1.0f;
    
    
    private void Awake()
    {
        float randomScale = Random.Range(_sizeMin, _sizeMax);
        
        transform.localScale = new Vector3(randomScale, randomScale, 0.0f);
    }
}
