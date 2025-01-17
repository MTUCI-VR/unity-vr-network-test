﻿using UnityEngine;

namespace PopovRadio.Scripts.Tools
{
    public static class Extensions
    {
        public static Vector3 RotatePointAroundPivot(this Vector3 point, Vector3 pivot, Vector3 angles)
        {
            var direction = point - pivot;
            direction = Quaternion.Euler(angles) * direction;
            return direction + pivot;
        }
    }
}