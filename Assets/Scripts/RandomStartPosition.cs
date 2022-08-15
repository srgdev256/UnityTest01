using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartPosition : MonoBehaviour
{
    private void Awake()
    {
        float randomX = Random.Range(ScreenBorders.Left, ScreenBorders.Right);
        float randomY = Random.Range(ScreenBorders.Bottom, ScreenBorders.Top);

        transform.position = new Vector3(randomX, randomY, 0.0f);
    }
}
