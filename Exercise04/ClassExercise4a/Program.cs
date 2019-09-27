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
            Console.WriteLine("Tien Dat Tr"); 
        }

        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
                return true;
            else return false;
        }

       public static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else return false;
        }

       public static bool IsPrime(int n)
       {
           if (n == 1) return true;
           for(int i=2; i<n; i++)
           {
               if(n % i ==0)
               return false;
           }
           return true;
       }

       public static int Square(int n)
       {

           return n * n;
       }

       public static int Cube(int n)
       {
           return n * n * n;
       }

        public static int Pow(int x, int y)
        {
            if (y == 0)
                return 1;
            if (y % 2 == 0)
                return Pow(x, y / 2) * Pow(x, y / 2);
            else
            if (y > 0)
                return x * Pow(x, y / 2) * Pow(x, y / 2);
            else
                return (Pow(x, y / 2) * Pow(x, y / 2)) / x;
        }

        public static int Abs(int n)
        {
            if (n >= 0)
                return n * 1;
            else
                return n * -1;
        }

        //public static int Ceil(float x)
        //{

        //}

        //public static int Floor(float x)
        //{

        //}

        public static int Rand1(int n)
        {
            Random a = new Random();
            for (int i = 0; i < n; i++)
                n = a.Next(0, 8);
            return n;
        }
    }
}
