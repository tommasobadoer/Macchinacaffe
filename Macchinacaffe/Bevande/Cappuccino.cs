using Front;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macchina_caffè.Bevande
{
    class Cappuccino : Prodotto, IProdotti
    {
        public Cappuccino(int zucchero) : base(0.65, new Dictionary<string, int>() {
            { "acqua", 2 },
            { "polvere caffè", 1 },
            { "latte", 1 }
        }, zucchero)
        { }
        public override void ProceduraPreparazione()
        {
            IFront front = new Front.Front();
            front.Stampa("ProceduraPreparazione");
        }
    }
}
