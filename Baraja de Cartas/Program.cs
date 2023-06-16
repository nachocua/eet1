using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_de_Cartas
{
    internal class Program
    {
        #region declaraciones
        static int i;
        static int j;
        static int auxnum;
        static int auxnum2;
        static Carta auxCarta = null;
        static string[] tipo = new string[4] { "basto", "espada", "oro", "copa" };
        static Random rnd = new Random();
        #endregion
        static void Main(string[] args)
        {   
            List<Carta> Baraja = new List<Carta>();
            Carta NodoCarta = null;
            for (i = 0; i < 4; i++) 
            {
                for(j = 0; j < 10; j++)
                {
                    auxnum = j+1;
                    if(auxnum > 7)
                    {
                        auxnum += 2;
                    }
                    NodoCarta = new Carta(auxnum, tipo[i]);
                    Baraja.Add(NodoCarta);
                }
            }
            Shuffle(Baraja);
            Console.WriteLine("MANO 1");
            for (j = 0; j < 2; j++)
            {
                Console.WriteLine("JUGADOR " + (j+1) );
                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine(Baraja[j*3+i].GetValor() + " de " + Baraja[j * 3 + i].GetTipo());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void Shuffle(List<Carta> lista)
        {
            for (i = 0; i < 1000; i++)
            {
                auxnum = rnd.Next(40);
                while ((auxnum2 = rnd.Next(40)) != auxnum)
                    auxCarta = lista[auxnum];
                lista[auxnum] = lista[auxnum2];
                lista[auxnum2] = auxCarta;
            }
        }
    }
}