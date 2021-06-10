using Front;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macchina_caffè.Bevande
{
    class Cioccolata : Prodotto
    {
        public Cioccolata(int zucchero) : base(0.5, new Dictionary<string, int>(){
            { "acqua", 2 },
            { "cacao", 1 },
            { "latte", 1 }
        }, zucchero) { }
        public override void ProceduraPreparazione()
        {
            IFront front = new Front.Front();
            front.Stampa("ProceduraPreparazione");
        }
    }
}
