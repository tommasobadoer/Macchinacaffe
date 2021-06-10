using Front;
using Macchina_caffè.Bevande;
using Macchinacaffe.Account;
using Macchinacaffe.ElementiMacchina;
using System;
using System.Collections.Generic;

namespace Macchinacaffe.Bevande
{
    public static class GestoreBevande
    {
        /// <summary>
        /// produce le bevande scelte
        /// </summary>
        /// <param name="ProduciBevanda"></param
        public static void ProduciBevanda(string lettura)
        {
            IFront front = new Front.Front();
            Dispensa dispensa = Dispensa.GetIsance();
            List<string> fasi = new() { "attendere", "preparazione" };
            Cassa cassa = Cassa.GetIstance();
            bool fine = false;
            //fine-> viene usato per finire la richiesta dell'inserimento dello zucchero se viene inserito un valore corretto
            int z=3;
            do
            {   
                
                try // controlla che il valore inserito sia un numero compreso tra 0 e 5
                {
                    z = int.Parse(front.Stampa("RichiestaZucchero"));
                    if (z < 6 && z > -1)
                    {
                        //inserimento corretto, quindi ho lo zucchero desiderato e posso terminare il ciclo
                        fine = false;
                    }
                    else
                    {
                        front.Stampa("Attesa");
                    }
                }
                catch (FormatException e)
                {
                   string errore= front.Stampa("Eccezione" + e.Message);
                    if (errore!=null)
                        return;
                }
            } while (fine);
            IProdotti prodotto = GeneraBevande.Genera(lettura, z);
            Dictionary<string, int> proc = prodotto.GetIngredienti();
            List<string> manca = dispensa.ControllaIngredienti(proc);
            if (manca.Count != 0) //controlla che ci siano tutti gli elementi necessari
            {
                string strmanca = ";";
                foreach (string s in manca)
                {
                    strmanca += s+";";
                }
                string errore=front.Stampa("Manca" + strmanca);
                if (errore != null)
                    return;
                front.Stampa("Attesa");
                return;
            } 

            if (Log.account != null) //decrementa il saldo dell'account se presente
            {
                if (Log.account.Saldo < prodotto.GetCosto())
                {
                    front.Stampa("CreditoInsufficente");
                    return;
                }

                Log.account.Aggiungi_denaro(-prodotto.GetCosto());
            }  
            else // decrementa i soldi dalla cassa 
            {
                if (cassa.Saldo < prodotto.GetCosto())
                {
                    front.Stampa("CreditoInsufficente");
                    return;
                }
                cassa.Togli(prodotto.GetCosto());
            }
            prodotto.ProceduraPreparazione();
            dispensa.Rimuovi(proc);
            front.Stampa("Preleva");
        }
    }
}
