using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankdepoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány évre szeretnéd lekötni a pénzt? ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Mekkora összeget szeretnél lekötni? ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Mi a lekötés kamata (%-ban)? ");
            double interestRate = double.Parse(Console.ReadLine());

            double totalAmount = principal * Math.Pow(1 + (interestRate / 100), years);
            Console.WriteLine($"A lekötés végén a teljes összeg: {totalAmount:F2} Ft");
        }
    }
}