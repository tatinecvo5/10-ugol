using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ugol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы g=");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты m=");
            int min = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите секунды s=");
            int sec = Convert.ToInt32(Console.ReadLine());
            Ugol ugol = new Ugol(gradus, min, sec);
            double totalRadian = ugol.ToRadian();
            Console.Write("Заданный угол составит ");
            Console.Write(totalRadian);
            Console.WriteLine("радиан");
            Console.ReadKey();
        }
    }
}
