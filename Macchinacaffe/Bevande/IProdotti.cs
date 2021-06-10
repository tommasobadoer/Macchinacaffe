using System.Collections.Generic;

namespace Macchina_caffè.Bevande
{
    public interface IProdotti
    {
        public Dictionary<string, int> GetIngredienti();
        public double GetCosto();
        void Dispose();
        public void ProceduraPreparazione();
    }
}
