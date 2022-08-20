using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using Random = UnityEngine.Random;

public class FreeformMovement : MonoBehaviour
{
    private Vector2 _direction;
    
    [SerializeField] 
    [Range(1.0f, 10.0f)]
    private float _speed;
    
    private void Awake()
    {
        float angle = Random.Range(0.0f, 360.0f);
        _direction = MathHelpers.UnitVectorFromAngle(angle);
    }

    private void Update()
    {
        float radius = transform.localScale.x * 0.5f;
        Vector2 curPosition = MathHelpers.ToVector2(transform.position);

        //wall collisions
        
        //up wall
        if (curPosition.y + radius >= ScreenBorders.Top)
        {
            if (_direction.y > 0f)
            {
                _direction.y = -_direction.y;
            }
        }
        
        //right wall
        if (curPosition.x + radius >= ScreenBorders.Right)
        {
            if (_direction.x > 0f)
            {
                _direction.x = -_direction.x;
            }
        }
        
        //down wall
        if (curPosition.y - radius <= ScreenBorders.Bottom)
        {
            if (_direction.y < 0f)
            {
                _direction.y = -_direction.y;
            }
        }
        
        //left wall
        if (curPosition.x - radius <= ScreenBorders.Left)
        {
            if (_direction.x < 0f)
            {
                _direction.x = -_direction.x;
            }
        }

        
        //moving
        Vector2 delta = _direction * (_speed * Time.deltaTime);
        transform.Translate(delta);

    }
}
