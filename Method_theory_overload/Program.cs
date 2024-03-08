using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_theory_overload
{
    class Calculator //создаём класс
    {
        public int result; //поле для хранения результатов

        public void Addition(int a, int b) //метод для вычисления суммы двух чисел
        {
            result = a + b;
            Console.WriteLine($"Результат сложения двух чисел {result}");
        }
        public void Addition(int a, int b,int c) //метод для вычисления суммы трёх чисел
        {
            result = a + b + c;
            Console.WriteLine($"Результат сложения двух чисел {result}");
        }

        public void Addition(int a, int b, int c, int d)//метод для вычисления суммы четырёх чисел
        {
            result = a + b + c + d;
            Console.WriteLine($"Результат сложения двух чисел {result}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();//создание экземпляра класса
            Console.WriteLine("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат первого метода: ");
            calculator.Addition(a, b); //вызов метода с 2мя параметрами
            Console.WriteLine();
            Console.WriteLine("Результат второго метода: ");
            calculator.Addition(a, b, c);// вызов метода с 3мя параметрами
            Console.WriteLine();
            Console.WriteLine("Результат третьего метода: ");
            calculator.Addition(a, b, c, d);// вызов метода с 4мя параметрами
            Console.ReadKey();
        }
    }
}
