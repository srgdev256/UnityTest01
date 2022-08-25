using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyByClick : MonoBehaviour, IPointerDownHandler
{
    private void Awake()
    {
        Collider2D collider2D = GetComponent<Collider2D>();
        
        if (collider2D == null)
        {
            // SphereCollider sc = gameObject.AddComponent<SphereCollider>() as SphereCollider;

            CircleCollider2D circleCollider2D = gameObject.AddComponent<CircleCollider2D>();
        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Destroy(gameObject);
    }
    
}
