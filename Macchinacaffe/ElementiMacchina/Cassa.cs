
using Front;
using Macchinacaffe.Account;
using System;

namespace Macchinacaffe.ElementiMacchina
{
    public class Cassa 
    {
        private static Cassa instance = null;
        public double Saldo { get; private set; }
        /// <param name="Saldo">soldi inseriti dall'utente</param>
        public void Inserisci()
        {
            IFront front = new Front.Front();
            bool fine = true;
            
            int c = 0;
            do
            {
                try
                {
                    c = int.Parse(front.Stampa("InserisciCredito"));
                    if (c > 0)
                        fine = false;
                }
                catch (FormatException e)
                {
                   string errore = front.Stampa("Eccezione;" + e.Message);
                    if (errore != null)
                        break;

                }
            } while (fine);
            Saldo += c;
        }
        public void Resto()
        {   
            IFront front = new Front.Front();
            if (Log.account == null)
            {
                string errore= front.Stampa("Resto;resto:\t" + Saldo);
                if(errore!=null)
                {
                    return;
                }
                Saldo = 0;
            }
            else
                front.Stampa("ImpossibilitaResto");
            
        }
        public static Cassa GetIstance()
        {
            if (instance == null)
            {
                instance = new Cassa();
            }
            return instance;
        }
        public void Togli(double costo)
        {
            Saldo -= costo;
        }
    }
}
