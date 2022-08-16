using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DiagonalMovement : MonoBehaviour
{
    
    //двигается по диагонали, отталкивается от границ экрана
    //radius = transform.scale.x * 0.5f
    
   
    
    private Direction _direction;
    
    [SerializeField] 
    [Range(1.0f, 10.0f)]
    private float _speed;
    
    private void Awake()
    {
        _direction = (Direction)Random.Range((int) Direction.UpLeft, (int) Direction.DownRight);
    }

    private void Update()
    {
        float delta = _speed * Time.deltaTime;

        float radius = transform.localScale.x * 0.5f;

        float curX = transform.position.x;
        
        float curY = transform.position.y;

        //wall collisions

        //up wall
        if (curY + radius >= ScreenBorders.Top)
        {
            if (_direction == Direction.UpRight)
            { 
                _direction = Direction.DownRight;
            }
            
            else
            {
                _direction = Direction.DownLeft;
            }
            
        }
        
        //right wall
        if (curX + radius >= ScreenBorders.Right)
        {
            if (_direction == Direction.UpRight)
            {
                _direction = Direction.UpLeft;
            }
            else
            {
                _direction = Direction.DownLeft;
            }
        }

        //down wall
        if (curY  - radius <= ScreenBorders.Bottom)
        {
            if (_direction == Direction.DownLeft)
            { 
                _direction = Direction.UpLeft;
            }
            else
            {
                _direction = Direction.UpRight;
            }
        }

        //left wall
        if (curX  - radius <= ScreenBorders.Left)
        {
            if (_direction == Direction.UpLeft)
            {
                _direction = Direction.UpRight;
            }
            else
            { 
                _direction = Direction.DownRight;
            }
        }
        
        //moving
        Vector3 moveDelta = Vector3.zero;
        
        switch (_direction)
        {
            case Direction.UpRight:
                moveDelta.x += delta;
                moveDelta.y += delta;
                break;


            case Direction.UpLeft:
                moveDelta.x -= delta;
                moveDelta.y += delta;
                break;


            case Direction.DownLeft:
                moveDelta.x -= delta;
                moveDelta.y -= delta;
                break;


            case Direction.DownRight:
            {
                moveDelta.x += delta;
                moveDelta.y -= delta;
                break;
            }
        }
        
        transform.Translate(moveDelta);

    }
}
