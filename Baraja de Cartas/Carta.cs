using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_de_Cartas
{
    internal class Carta
    {
        int numero;
        string tipo;
        public Carta(int numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }
        public int GetValor()
        {
            return numero;
        }
        public string GetTipo()
        {
            return tipo;
        }
    }
}
