using Front;
using System.Collections.Generic;

namespace Macchina_caffè.Bevande
{ 
    class CaffeLungo : Prodotto
    {
        public CaffeLungo(int zucchero) : base(0.6, new Dictionary<string, int>(){
            { "acqua", 3 },
            { "polvere caffè", 1 }
        }, zucchero) { }
        public override void ProceduraPreparazione()
        {
            IFront front = new Front.Front();
            front.Stampa("ProceduraPreparazione");
        }
    }
}
