using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi hack";

            Console.WriteLine("Inputkan nilai a:    ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Inputkan nilai b:    ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hasil penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil perkalian: {0} x {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil pembagian: {0} : {1} = {2}", a, b, Pembagian(a, b));

            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
