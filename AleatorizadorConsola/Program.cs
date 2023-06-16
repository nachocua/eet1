using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleatorizadorConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            nombres[0] = "Ruiz";
            nombres[1] = "Sircelj";
            nombres[2] = "Passarino";
            nombres[3] = "Pedron";
            nombres[4] = "Saucedo";
            nombres[5] = "Monzon";
            nombres[6] = "Waigel"; //14/06
            nombres[7] = "Galvan";
            Random rnd = new Random();
            Console.WriteLine(nombres[rnd.Next(8)]);
            Console.ReadKey();
        }
    }
}
