using System;

namespace SimpleApp
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Multiply(int a, int b) => a * b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("🎯 Проект для обучения CI/CD!");
            Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
            Console.WriteLine($"2 * 3 = {calc.Multiply(2, 3)}");
            Console.WriteLine("✅ Всё работает!");
        }
    }
}