using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    [SerializeField] 
    [Range(1.0f, 10.0f)]
    private float _speed;
    
    
    private void Update()
    {
        float delta = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-delta, 0.0f, 0.0f);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(delta, 0.0f, 0.0f);
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0.0f, delta, 0.0f);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, -delta, 0.0f);
        }
    }
}
