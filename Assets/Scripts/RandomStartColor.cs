using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomStartColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    
    [SerializeField] 
    private float hueMin = 0.0f;
    
    [SerializeField] 
    private float hueMax = 360.0f;
    
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = Random.ColorHSV(hueMin, hueMax);
    }
}
