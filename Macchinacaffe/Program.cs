using System;
using Macchinacaffe.Bevande;
using Front;
using Macchinacaffe.ElementiMacchina;
using Macchinacaffe.Account;

namespace Macchinacaffe
{
    class Program
    {
        static void Main()
        {
            IFront front = new Front.Front();
            Cassa cassa = Cassa.GetIstance();
            bool fine = true;
            AccountManager.Crea(new Account.Account("manutentore", "Passwordmanutenotre"));

            do
            {
                string lettura = front.Stampa("StampaElenco");
                switch (lettura)
                {
                    case "crea":
                        //avvia la procedura per creare un account
                        Log.CreaAccount();
                        front.Stampa("Attesa");
                        break;
                    case "elimina":
                        //avvia la procedura per eliminare un account (se loggato)
                        Log.ELiminaAccount();
                        front.Stampa("Attesa");
                        break;
                    case "log-in":
                        // logga un utente (se nessuno lo è già)
                        Log.LogIn();
                        front.Stampa("Attesa");
                        break;
                    case "log-out":
                        //effettua il log-out di un utene (se loggato)
                        Log.LogOut();
                        front.Stampa("Attesa");
                        break;
                    case "caffè":
                    case "cappuccino":
                    case "cioccolata":
                    case "the":
                    case "caffè lungo":
                        GestoreBevande.ProduciBevanda(lettura);
                        break;
                    case "fine":
                        //termina il do...while
                        fine = false;
                        break;
                    case "aggiungi":
                        //a seconda se un utente è oggato o meno icrementa il credito 
                        if (Log.account == null)
                            cassa.Inserisci();
                        else
                            Log.RicaricaCredito();
                        front.Stampa("Attesa");
                        break;
                    case "resto":
                        cassa.Resto();
                        front.Stampa("Attesa");
                        break;
                    case "aggiungi dispensa":
                        //opzione per il manutentore per aggiungere gli ingredienti nella dispensa
                        Log.RicaricaInventario();
                        front.Stampa("Attesa");
                        break;
                    default:
                        front.Stampa("InserimentoNonValido");
                        break;
                }
                front.Stampa("Dispose");
            } while (fine);
            if (Log.account != null)
            {
                Log.LogOut();
            }
        }
    }
}