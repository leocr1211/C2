using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp2aula03.restauranteclasse
{
    class prato
    {
        public string nomes;
        public double calorias, carboidratos, proteinas, sodio, gorduras;

        public prato(string nome, double cal, double carb, double prot, double sod, double gord)
        {
            nomes = nome;
            calorias = cal;
            carboidratos = carb;
            proteinas = prot;
            sodio = sod;
            gorduras = gord;
        }
    }
}
