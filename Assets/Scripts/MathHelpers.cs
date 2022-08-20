using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathHelpers
{
	public static Vector2 UnitVectorFromAngle(float angleInDegrees)
	{
		float angle = angleInDegrees * Mathf.Deg2Rad;
		float x = Mathf.Cos(angle);
		float y = Mathf.Sin(angle);
		return new Vector2(x, y);
	}


	public static Vector2 VectorFromAngleMagnitude(float angleInDegrees, float magnitude)
	{
		float angle = angleInDegrees * Mathf.Deg2Rad;
		float x = Mathf.Cos(angle);
		float y = Mathf.Sin(angle);
		return new Vector2(x * magnitude, y * magnitude);
	}


	public static Vector2 ToVector2(Vector3 src)
	{
		return new Vector2(src.x, src.y);
	}
}
