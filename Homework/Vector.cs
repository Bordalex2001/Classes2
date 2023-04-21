using System;

namespace Homework
{
    internal class Vector
    {
        private int x; //Координата x
        private int y; //Координата y
        private int z; //Координата z
        public Vector() //Конструктор по умолчанию
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Vector(int x) //Конструктор с одним параметром
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector(int x, int y) : this(x) //Конструктор с двумя параметрами
        {
            this.y = y;
            this.z = z;
        }
        public Vector(int x, int y, int z) : this(x, y) //Конструктор с тремя параметрами
        {
            this.z = z;
        }
        ~Vector() { } //Деструктор
        public int X
        {
            get { return x; } set { x = value; }
        }
        public int Y
        {
            get { return y; } set { y = value; }
        }
        public int Z
        {
            get { return z; } set { z = value; }
        }
        public void Enter() //Ввод координат вектора
        {
            Console.WriteLine("Enter vector coords");
            Console.Write("x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z: ");
            z = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString() //Вывод координат вектора
        {
            return $"<{x}, {y}, {z}>";
        }
        public void CoordsOut(int x, int y, int z, out int c1, out int c2, out int c3) //Метод возвращает координаты через выходные параметры out
        {
            c1 = x;
            c2 = y;
            c3 = z;
        }
        public void VLengthOut(int x, int y, int z, out double length) //Метод возвращает длину вектора через выходной параметр out
        {
            double sq_sum = x * x + y * y + z * z;
            length = Math.Sqrt(sq_sum);
        }
        public void MultByScalar(Vector vector, in int scalar) //Увеличение координат вектора на скаляр (1 входной параметр in)
        {
            x *= scalar;
            y *= scalar;
            z *= scalar;
        }
        public Vector Sum(ref Vector vector) //Сумма векторов (1 параметр ref)
        {
            x += vector.X;
            y += vector.Y;
            z += vector.Z;
            return this;
        }
        public Vector Difference(ref Vector vector) //Разность векторов (1 параметр ref)
        {
            x -= vector.X;
            y -= vector.Y;
            z -= vector.Z;
            return this;
        }
        public Vector Product(ref Vector vector) //Поэлементное произведение векторов (1 параметр ref)
        {
            x *= vector.X;
            y *= vector.Y;
            z *= vector.Z;
            return this;
        }
        public int ScalarProduct(ref Vector vector, ref int sp) //Скалярное произведение векторов (2 параметра ref)
        {
            x *= vector.X;
            y *= vector.Y;
            z *= vector.Z;
            sp = x + y + z;
            return sp; //Скалярное произведение
        }
        public bool Equality(ref Vector vector, ref bool equal) //Равность векторов (2 параметра ref)
        {
            equal = false;
            if (x == vector.X && y == vector.Y && z == vector.Z)
            {
                equal = true;
            }
            return equal; 
        }
    }
}
