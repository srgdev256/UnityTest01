using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using static UnityEngine.Time;

public class RandomTargetMovement : MonoBehaviour
{
    private const float NearTargetRadius = 0.25f;
    
    private Vector2 _targetPosition;
    
    [SerializeField] 
    [Range(1.0f, 10.0f)]
    private float targetChangePeriod;
    
    [SerializeField] 
    [Range(1.0f, 10.0f)]
    private float _speed;
    
    private float _curTime;
    
    private void Awake()
    {
        PickTarget();
    }

    private void Update()
    {
        Vector2 curPosition = MathHelpers.ToVector2(transform.position);

        float distanceToTarget = Vector2.Distance(curPosition, _targetPosition);

        if (distanceToTarget > NearTargetRadius)
        {
            var directionToTarget = (_targetPosition - curPosition) / distanceToTarget;

            Vector2 delta = directionToTarget * (_speed * Time.deltaTime);
            
            transform.Translate(delta);
        }
        
        _curTime += Time.deltaTime;

        if (_curTime >= targetChangePeriod)
        {
           PickTarget();
           _curTime = 0f;
        }
    }

    private void PickTarget()
    {
        float radius = transform.localScale.x * 0.5f;
        _targetPosition = ScreenBorders.GetRandomPoint(radius);
    }
}
