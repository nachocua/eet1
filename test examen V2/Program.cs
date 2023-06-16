using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace test_examen_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaracion de variables
            int cantidad = 20,  //cantidad de vehiculus <- modificable
                opcion,         //se usa para el menú
                dato,           //ingresado por el usuario para el modelo
                cantidadVentasTotales = 0;
            int[] precio = new int[cantidad];
            int[] cantidadVendida = new int[cantidad];
            #endregion
            /*Random random = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                precio[i] = random.Next(100, 570);
            }*/
            GenerarValoresRNG(precio, cantidad, 570);
            #region menu
            do
            {
                Console.WriteLine("1 - Cargar compra");
                Console.WriteLine("2 - Mostrar Informes");
                Console.WriteLine("3 - Mostrar lista de precios");
                Console.WriteLine("99 - Salir");
                while (!(Int32.TryParse(Console.ReadLine(), out opcion)))
                {
                    Console.WriteLine("Debe ingresar un valor");
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el número de modelo (1-20 o 0 para salir)");
                        while (!(int.TryParse(Console.ReadLine(), out dato)))
                        {
                            Console.WriteLine("Debe ingresar un dato válido");
                        }
                        if (dato > 0 && dato < 21)
                        {
                            cantidadVendida[dato - 1]++;
                            cantidadVentasTotales++;
                        }
                        break;
                    case 2:
                        if (cantidadVentasTotales == 0)
                        {
                            Console.WriteLine("Para informar los resultados, debe haber hecho al menos 1 venta");
                        }
                        else
                        {
                            double prom = 0;
                            for (int i = 0; i < cantidad; i++)
                            {
                                prom += cantidadVendida[i] * precio[i];
                            }
                            Console.WriteLine("El promedio de las ventas fue de: " + (prom / cantidadVentasTotales));
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine((i + 1) + " - $" + precio[i]);
                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (!(opcion == 99));
            #endregion
        }
        public static void GenerarValoresRNG(int[] vectorDatos, int size)
        {
            Random rng = new Random();
            for (int i = 0; i < size; i++)
            {
                vectorDatos[i] = rng.Next();
            }
        }
        public static void GenerarValoresRNG(int[] vectorDatos, int size, int maxValue)
        {
            Random rng = new Random();
            for (int i = 0; i < size; i++)
            {
                vectorDatos[i] = rng.Next(maxValue);
            }
        }
        public static void GenerarValoresRNG(int[] vectorDatos, int size, int maxValue, int minValue)
        {
            Random rng = new Random();
            for (int i = 0; i < size; i++)
            {
                vectorDatos[i] = rng.Next(minValue, maxValue);
            }
        }
    }
}