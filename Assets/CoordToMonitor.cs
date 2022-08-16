using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordToMonitor
{
    public static Vector3 angleToVector3(float rightAscension, float declination, float r)
	{
		return new Vector3(r * Mathf.Cos(rightAscension) * Mathf.Cos(declination), r * Mathf.Sin(declination), r * Mathf.Sin(rightAscension) * Mathf.Cos(declination));
	}
}