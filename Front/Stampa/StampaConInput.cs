using Front.Schermo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Stampa

{
    class StampaConInput
    {
        public void StampaEccezione(string s)
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa(s);
            mSchermi.Dispose();
        }
        public void Manca(string[] s)
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            foreach (string manca in s)
            {
                mSchermi.SetStampa("manca:\t" + manca);
            }

        }
        public void Resto(string s)
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa(s);
            mSchermi.Dispose();
        }
    }
}
