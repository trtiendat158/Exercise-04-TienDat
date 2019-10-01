using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise4a
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                try
                {
                    Console.WriteLine("Vui long nhap n: ");
                    long n = long.Parse(Console.ReadLine());
                    Console.WriteLine("Vui long nhap x: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Vui long nhap y: ");
                    double y = double.Parse(Console.ReadLine());
                    UserInput(n, x, y);
                }
                catch (Exception)
                {
                    Console.WriteLine("Vui long nhap lai vi n thuoc kieu long, x thuoc kieu double, y thuoc kieu double");
                    Console.WriteLine("-------------------------------------------");
                }
            }
            Console.ReadLine();
        }

        public static bool IsOdd(int n)
        {
            Console.Write("{0} Isodd is: ", n);
            if (n % 2 != 0)
                return true;
            else return false;
        }

        public static bool IsEven(int n)
        {
            Console.Write("{0} Iseven is: ", n);
            if (n % 2 == 0)
                return true;
            else return false;
        }

        public static bool IsPrime(int n)
        {
            Console.Write("{0} Isprime is: ", n);
            if (n == 1) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static int Square(int n)
        {
            Console.Write("Square of {0} is: ", n);
            return n * n;
        }

        public static int Cube(int n)
        {
            Console.Write("Cube of {0} is: ", n);
            return n * n * n;
        }

        public static int Pow(int x, int y)
        {
            Console.Write("Pow of {0} and {1} is: ", x ,y);
            //if (y == 0)
            //    return 1;
            //if (y % 2 == 0)
            //    return Pow(x, y / 2) * Pow(x, y / 2);
            //else
            //    if (y > 0)
            //        return x * Pow(x, y / 2) * Pow(x, y / 2);
            //    else
            //        return (Pow(x, y / 2) * Pow(x, y / 2)) / x;

            int kq = x;
            if (y < 0)
            {
                return 0;
            }
            if (y == 0)
            {
                return 1;
            }
            if (y == 1) return kq;
            for (int i = 2; i <= y; i++)
            {
                kq *= x;
            }
            return kq;
        }

        public static int Abs(int n)
        {
            Console.Write("Abs of {0} is: ", n);
            if (n >= 0)
                return n * 1;
            else
                return n * -1;
        }

        public static int Ceil(float x)
        {
            Console.Write("Ceil of {0} is: ", x);
            int kq = (int)x;
            if (x != kq)
                if (x > kq) 
                 kq += 1;
            return kq;
        }

        public static int Floor(float x)
        {
            Console.Write("Floor of {0} is: ", x);
            int kq = (int)x;  
            if (x >= kq) return kq;
            else return kq - 1;

        }

        public static int Rand1()
        {
            Console.Write("Random from 2 to 2^31-1 of {0} is: ");
            int kq = 2;
            int kq2;
            for (int i = 2; i <= 31; i++)
            {
                kq *= 2;
            }
            Random a = new Random();
            return kq2 = a.Next(0, kq - 1);


        }

        public static float Rand2()
        {
            Console.Write("between 0 and 1 of {0} is: ");
            Random rd = new Random();
            float f = (float)rd.NextDouble();
            Console.Write("random từ giữa 0 đến 1: ");
            return f;

        }
        public static long Factorial(long n)
        {
            Console.Write("Factorial của {0}: ", n);
            long kq = 1;
            if (n == 0) return 1;
            else if (n < 0)
            {
                Console.Write("kq ra 0 => vô nghiệm ,");
                return 0;
            }
            else
            {
                for (long i = 1; i <= n; i++)
                {
                    kq *= i;
                }
                return kq;
            }
        }
        public static void UserInput(long n, double x, double y)
        {
            Console.WriteLine(IsOdd((int)n));
            Console.WriteLine(IsEven((int)n));
            Console.WriteLine(IsPrime((int)n));
            Console.WriteLine(Square((int)n));
            Console.WriteLine(Cube((int)n));
            Console.WriteLine(Pow((int)x, (int)y));
            Console.WriteLine(Abs((int)n));
            Console.WriteLine(Ceil((float)x));
            Console.WriteLine(Floor((float)x));
            Console.WriteLine(Rand1());
            Console.WriteLine(Rand2());
            Console.WriteLine(Factorial(n));
            Console.WriteLine("----------------------------------------------------------------");
        }

    }
}
