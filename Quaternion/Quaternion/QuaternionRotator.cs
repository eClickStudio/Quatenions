using System;
using System.Numerics;

namespace Quaternions
{
    internal static class QuaternionRotator
    {
        /// <summary>
        /// Rotates the vector along the axis by an angle
        /// </summary>
        /// <param name="vector">Vector you want to rotate</param>
        /// <param name="axis">Rotation axis</param>
        /// <param name="angle">angle in radians</param>
        /// <returns>Rotated vector</returns>
        public static Vector3 Rotate(Vector3 vector, Vector3 axis, double angle)
        {
            axis = Vector3.Normalize(axis);

            Quaternion directionQuaternion = new Quaternion(0, vector.X, vector.Y, vector.Z);

            float cos = (float)Math.Cos(angle / 2);
            float sin = (float)Math.Sin(angle / 2);
            Quaternion axisQuaternion = new Quaternion(cos, sin * axis.X, sin * axis.Y, sin * axis.Z);

            Quaternion resultQuaternion = (axisQuaternion * directionQuaternion) * Quaternion.Сonjugate(axisQuaternion);

            return new Vector3(resultQuaternion.b, resultQuaternion.c, resultQuaternion.d);
        }
    }
}
