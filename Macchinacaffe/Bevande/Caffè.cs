using Front;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macchina_caffè.Bevande
{
    class Caffè : Prodotto, IProdotti
    { 
        public Caffè(int zucchero) : base(0.5, new Dictionary<string, int>(){
            { "acqua", 2 },
            { "polvere caffè", 1 }
        }, zucchero) { }

        public override void ProceduraPreparazione()
        {
            IFront front = new Front.Front();
            front.Stampa("ProceduraPreparazione");
        }
    }
    
}
