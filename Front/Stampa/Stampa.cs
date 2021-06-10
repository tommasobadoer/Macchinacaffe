using Front.Schermo;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Front.Stampa
{
    class Stampa
    {
        public Stampa()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            Schermo.Schermo schermo = new Schermo.Schermo();
            mSchermi.Attach(schermo);
        }

        public string StampaElenco()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetNull();
               mSchermi.SetStampa("inserisci \"crea\" per creare un account \n"
                                   + "inserisci \"elimina\" per eliminare un account \n" +
                                   "inserisci \"log-in\" per accedere ad un account\n" +
                                   "inserisci \"log-out\" per disconnettere l'account\n" +
                                   "inserisci \"aggiungi\" per aggiungere credito\n" +
                                   "inserisci \" caffè\" per preparare un caffè\n" +
                                   "inserisci \"cappuccino\" per preparare un cappuccino\n" +
                                   "inserisci \"the\" per preparare il the\n" +
                                   "inserisci \"caffè lungo\" per preparare un caffè lungo\n" +
                                   "inserisci \"cioccolata\" per preparare una cioccolata\n" +
                                   "inserisci \"fine\" per terminare\n" +
                                   "inserisci \"resto\" per ricevere il resto (non verrà effettuato se loggati) \n" +
                                   "inserisci \"aggiungi dispensa\" per inserire elementi nella dispensa\n");
            mSchermi.Dispose();
            return Tastiera.GetImput();
        }

        public string GetUsernameLog()
        {  
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("inserisci usermane");
            mSchermi.Dispose();
            return Tastiera.GetImput();
        }
        public string GetPasswordLog()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("inserisci la password minimo 6 caratteri\n" +
                        "(deve contenere almeno una lettera maiuscola, un numero e un carattere speciale)");
            mSchermi.Dispose();
            return Tastiera.GetImput();
        }
        public void StampaErrorrPassword()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("password non idonea");
            mSchermi.SetStampa("\npremere \"invio\" per proseguire");
            Tastiera.GetImput(); 
            mSchermi.SetNull();
            mSchermi.Dispose();
        }
       
        public void Attesa()
        {
            ManagerSchermi mScgermi = ManagerSchermi.GetIstance();
            mScgermi.SetStampa("\npremere \"invio\" per proseguire");
            Tastiera.GetImput();
            mScgermi.SetNull();
            mScgermi.Dispose();
        }
        public void AccountMiss()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("account non trovato");
            mSchermi.Dispose();
        }
        public void LogIn()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("log-in effettuato");
            mSchermi.Dispose();
        }
        public void AccountCollegto()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("account già collegato");
            mSchermi.Dispose();
        }
        public void LogOut()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("log-out effettuato");
            mSchermi.Dispose();
        }
        public void AccountEsiste()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("account già esistente");
            mSchermi.Dispose();
        }
        public void Elimina()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("eliminato");
            mSchermi.Dispose();
        }
        public string InserisciCredito()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("quanto vuoi inserire? ");
            mSchermi.Dispose();
            return Tastiera.GetImput();
            
        }
        public void Fatto()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("effettuato");
            mSchermi.Dispose();
        }
        public void AccountCreato()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("account creato\n");
            mSchermi.Dispose();
        }
        public void ImpossibilitaAccesso()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("impossibile effettuare l'operazione");
            Tastiera.GetImput();
            mSchermi.Dispose();
        }
        public string StampaPerManutentore()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetNull(); 
            mSchermi.SetStampa("\nquale prodotto vuoi inserire??\n" +
                       "inserisci \"acqua\" per aggiungere l'acqua \n" +
                        "inserisci \"polvere caffè\" per aggiungere la polvre di caffè \n" +
                        "inserisci \"latte\" per aggiungere il latte  \n" +
                        "inserisci \"zucchero\" per aggiungere lo zucchero  \n" +
                        "inserisci \"polvere the\" per aggiungere la polvere the  \n" +
                        "inserisci \"cacao\" per aggiungere il cacao  \n" +
                        "inserisci \"fine\" per terminare l'inserimento\n");
            mSchermi.Dispose();
            return Tastiera.GetImput();
        }
        public string InserimentoQuantità()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("inserire quantità");
            mSchermi.Dispose();
            return Tastiera.GetImput();
        }
        public void InserimentoNinValido()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("inserimento non valido");
            Tastiera.GetImput();
            mSchermi.Dispose();
        }
        public void AggiornamentoDispensa()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("dispensa aggiornata");
            mSchermi.Dispose();
        }
        public void StapaFasiPreparazione()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            List<string> fasi = new() { "attendere", "preparazione" };
            foreach (string s in fasi)
            {   
                mSchermi.SetStampa(s);
                Thread.Sleep(2000);
            }
            mSchermi.Dispose();
        }
        public string RischiestaZucchero()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("quanto zucchero? tra 0 e 5 ");
            mSchermi.Dispose();
            return Tastiera.GetImput();
        }
        public void Preleva()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("\npremere \"invio\" per prelevare");
            Tastiera.GetImput();
            mSchermi.SetNull();
            mSchermi.Dispose();
        }
        public void CreditoInsufficente()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("credito insufficiente");
            Attesa();
            mSchermi.Dispose();
        }
       
        public void ImpossibileResto()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.SetStampa("impossibile se l'account è loggato");
            mSchermi.Dispose();
        }
        public void Dispose()
        {
            ManagerSchermi mSchermi = ManagerSchermi.GetIstance();
            mSchermi.Dispose();
        }
    }
}
