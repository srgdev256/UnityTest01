using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ClickWorldPosition : MonoBehaviour, IPointerDownHandler
{

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Vector2 mousePos = pointerEventData.position;
        
        var point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        Debug.Log("world pos:" + point);
    }

}
