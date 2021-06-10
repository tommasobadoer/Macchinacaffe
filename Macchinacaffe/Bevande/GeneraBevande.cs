using Macchina_caffè;
using Macchina_caffè.Bevande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macchinacaffe.Bevande
{
    public static class GeneraBevande
    {
        public static IProdotti Genera(string Selezione, int z)
        {
            return Selezione switch
            {
                "caffè" => new Caffè(z),
                "cappuccino" => new Cappuccino(z),
                "cioccolata" => new Cioccolata(z),
                "the" => new The(z),
                "caffè lungo" => new CaffeLungo(z),
                _ => null,
            };
        }
    }
}
