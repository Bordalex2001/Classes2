using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Vector");
            Console.WriteLine("Vector A");
            Vector vec1 = new Vector();
            vec1.Enter();
            Console.WriteLine("\n");
            Console.WriteLine(vec1.ToString());
            int a = vec1.X;
            int b = vec1.Y;
            int c = vec1.Z;
            int c1, c2, c3;
            double length;
            vec1.CoordsOut(a, b, c, out c1, out c2, out c3);
            Console.WriteLine($"Coordinate X: {c1} \tCoordinate Y: {c2} \tCoordinate Z: {c3}");
            vec1.VLengthOut(a, b, c, out length);
            Console.WriteLine("Vector length: " + length);
            Console.Write("\nEnter a scalar to multiply the vector: ");
            int s = Convert.ToInt32(Console.ReadLine());
            vec1.MultByScalar(vec1, s);
            Console.WriteLine($"Lambda x: {vec1.X} \tLambda y: {vec1.Y} \tLambda z: {vec1.Z}");
            Console.WriteLine("\nVector B");
            Vector vec2 = new Vector();
            vec2.Enter();
            Console.WriteLine("\n");
            Console.WriteLine(vec2.ToString());
            Console.WriteLine("Sum of these vectors: " + vec1.Sum(ref vec2));
            Console.WriteLine("Difference of these vectors: " + vec1.Difference(ref vec2));
            Console.WriteLine("Product of these vectors: " + vec1.Product(ref vec2));
            int sp = 0;
            bool equal = false;
            Console.WriteLine("Scalar product of these vectors: " + vec1.ScalarProduct(ref vec2, ref sp));
            Console.WriteLine("Vector A equals vector B: " + vec1.Equality(ref vec2, ref equal));
            Console.WriteLine();
        }
    }
}
