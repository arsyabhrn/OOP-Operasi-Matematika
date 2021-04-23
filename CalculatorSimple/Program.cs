using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan pertambahan = new Pertambahan(4, 2);
            Console.WriteLine(pertambahan.Proccess());
            pertambahan.Display();

            Pengurangan pengurangan = new Pengurangan(4, 2);
            Console.WriteLine(pengurangan.Proccess());
            pengurangan.Display();

            Perkalian perkalian = new Perkalian(4, 2);
            Console.WriteLine(perkalian.Proccess());
            perkalian.Display();

            Pembagian pembagian = new Pembagian(4, 2);
            Console.WriteLine(pembagian.Proccess());
            pembagian.Display();
        }
    }
}
