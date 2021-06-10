using System;
using System.Collections.Generic;

namespace Macchina_caffè.Bevande
{
    abstract class Prodotto : IProdotti, IDisposable
    {
       
        

        private double Costo;
        protected Dictionary<string, int> Ingredienti = new();
        public Prodotto(double costo, Dictionary<string, int> proc, int zucchero)
        {
             this.Costo = costo;
            Ingredienti = proc;
            Ingredienti.Add("zucchero", zucchero);
        }
        public void Dispose()
        {   
            GC.SuppressFinalize(this);
        }
        public Dictionary<string, int> GetIngredienti()
        {
            return Ingredienti;
        }
        public double GetCosto()
        {
            return Costo;
        }

        public abstract void ProceduraPreparazione();
        
    }
}
