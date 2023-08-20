using System;
using System.Numerics;

namespace Quaternions
{
    class Program
    {
        static void Main()
        {
            Vector3 direction = new Vector3(-4, -2, -4);
            Vector3 axis = new Vector3(0, 6, 0);
            double angle = Math.PI / 4;

            Console.WriteLine(QuaternionRotator.Rotate(direction, axis, angle));
        }
    }
}
