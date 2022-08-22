using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartPosition : MonoBehaviour
{
    private void Awake()
    {
        float radius = transform.localScale.x * 0.5f;
        transform.position = ScreenBorders.GetRandomPoint(radius);
    }
}
