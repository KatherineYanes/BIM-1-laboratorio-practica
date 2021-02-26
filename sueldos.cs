using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            char op = 's';
            while (op == 's')
            { 
             Console.WriteLine("Ingrese el salario por hora");
             a = double.Parse(Console.ReadLine());
             Console.WriteLine("Horas que trabajó");
             b = double.Parse(Console.ReadLine());

             c = a * b;
             Console.WriteLine("Su sueldo es de: " + c);

             Console.WriteLine("¿Desea calcular el sueldo se otro trabajador? ['s/n']");
             op = char.Parse(Console.ReadLine());
             Console.Clear();

            }
            

        }
    }
}
