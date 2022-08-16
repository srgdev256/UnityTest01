using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBorders : MonoBehaviour
{
    
    public static float Left => -_instance._camera.orthographicSize * _instance._camera.aspect;
    public static float Right => _instance._camera.orthographicSize * _instance._camera.aspect;
    public static float Top => _instance._camera.orthographicSize;
    public static float Bottom => -_instance._camera.orthographicSize;

    private Camera _camera;

    private static ScreenBorders _instance;
    
    private void Awake()
    {
        _instance = this;
        _camera = GetComponent<Camera>();
    }



}
