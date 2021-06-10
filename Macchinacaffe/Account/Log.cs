using Macchina_caffè;
using System;
using System.Text.RegularExpressions;
using Front;
using Macchinacaffe.Account;

namespace Macchinacaffe.Account
{
    public static class Log
    {
        public  static Account account;
        public static void  LogIn()
        {
            IFront front = new Front.Front();

            if (account == null)
            {
                try
                {
                    string username = front.Stampa("GetUsernameLog");
                    string password= front.Stampa("GetUserPassword");
                    account = AccountManager.LogIn(username, password);
                }
                catch (Exception e)
                {
                    front.Stampa("Eccezione;"+e.Message);
                    return;
                }
                if (account == null)
                {
                    front.Stampa("AccountMiss");
                }
                else
                {
                    front.Stampa("LogIn");
                }
            }
            else
            {
                front.Stampa("AccountColegato");
            }
        }
        public static void LogOut()
        {
            IFront front = new Front.Front();
            if (account != null)
            {
                account.LogOut();
                account = null;
                front.Stampa("LogOut");
            }
            else { front.Stampa("AccountMiss"); }
        }
        public static void CreaAccount()
        {
            IFront front = new Front.Front();
            try
            {
                string username = front.Stampa("GetUsernameLog");
                Regex rxPass = new(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{6,50}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                string psw;
                bool fine;
                do
                {
                    fine = true;
                    psw = front.Stampa("GetUserPassword");
                    if (!rxPass.IsMatch(psw))
                    {
                        front.Stampa("ErrorePassword");
                    }
                    else
                    {
                        fine = false;
                    }
                } while (fine);
               
                account = Account.Crea(username,psw );
            }
            catch (Exception e)
            {
                front.Stampa("Eccezione;" + e.Message);
                return;
            }
            if (account == null)
            {
                front.Stampa("AccountEsistente");
                return;
            }
            else
            {
                front.Stampa("AccountCreato");
            }
            front.Stampa("LogIn");
            
        }
        public static void ELiminaAccount()
        {
            IFront front = new Front.Front();
            if (account != null)
            {
                account.Elimina();
                front.Stampa("Elimina");
                account = null;
            }
            else { front.Stampa("AccountMiss"); }
        }
        public static void RicaricaCredito()
        {
            IFront front = new Front.Front();
            bool fine = true;
            int c=0;
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
                   string errore= front.Stampa("Eccezione;"+e.Message);
                    if (errore != null)
                        break;
                }
            } while (fine);
            account.Aggiungi_denaro(c);
            front.Stampa("Fatto");
        }
        /// <summary>
        /// metodo che permette agli account manutentori di inserire prodotti nella dispensa
        /// </summary>
        /// <param name="RicaricaInventario"></param>
        public static void RicaricaInventario()
        {
            Account.AggiungiIngredienti();
        }
    }
}
