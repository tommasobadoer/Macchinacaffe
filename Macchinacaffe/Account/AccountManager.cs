using Front;
using System;
using System.Collections.Generic;

namespace Macchinacaffe.Account
{
    public static class AccountManager 
    {
        /// <summary>
        /// contiene la lista di tuttgli account presenti nella macchina
        /// </summary>
        /// <param name="LAccounts"></param>
        static List<Account> LAccounts = new List<Account>();
        public static Account Crea(Account tmp)
        {
            Account x = Trova(tmp.Username, tmp.Password);
            if (x == null)
            {
                LAccounts.Add(tmp);
                return null;
            }
            return x;
        }
        public static  void Elimina(Account tmp) => LAccounts.Remove(tmp);
        static  public Account LogIn(string user,string pass)
        {
           return Trova(user, pass);
        }
        public static Account Trova(string user, string pass)
        {
            try
            {
                foreach (Account a in LAccounts)
                {
                    if (a.Esiste(user, pass))
                        return a;
                }
            }
            catch (Exception e) 
            {
                IFront front = new Front.Front();
                front.Stampa("Eccezione" + e.Message);
                return null;
            }
            return null;
        }
        public static bool Lenght()
        {
            if (LAccounts.Count == 0) { return true; }
            else { return false; }
        }
    }
}
