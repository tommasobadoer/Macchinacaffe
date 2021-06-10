using Front;
using Macchina_caffè;
using Macchina_caffè.Bevande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macchinacaffe.Bevande
{
    class The : Prodotto
    {
        public The( int zucchero) : base(0.5, new Dictionary<string, int>(){
            { "acqua", 2 },
            { "polvere the", 1 }
        }, zucchero) {}
        public override void ProceduraPreparazione()
        {
            IFront front = new Front.Front();
            front.Stampa("ProceduraPreparazione");
        }
    }
}
