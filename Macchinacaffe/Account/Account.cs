using Front;
using Macchinacaffe.ElementiMacchina;
using System;
using System.Collections.Generic;

namespace Macchinacaffe.Account
{
    public class Account: IDisposable
    {
        private static bool IsManutentore { get; set; }
        public string Username { get; }
        public string Password { get; }
        public  double Saldo { get; private set; }
        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            Saldo = 0;
            IManutentore();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public void Elimina()
        {
            AccountManager.Elimina(this);
            Dispose();
        }
        public bool Esiste(string u, string p)
        {
            if (this.Username.Equals(u) && this.Password.Equals(p))
                return true;
            return false;
        }
        public void Aggiungi_denaro(double d) => Saldo += d;
        public static Account Crea(string user, string pass)
        {
            Account tmp = new(user, pass);
            Account Istance = AccountManager.Crea(tmp);
            if (Istance == null)
            {
                return tmp;
            }
            return null;
        }
        public void LogOut()
        {
            this.Dispose();
        }
        public static void AggiungiIngredienti()
        {
            IFront front = new Front.Front();
            if (!IsManutentore)
            {
                front.Stampa("ImpossibilitaOperazione");
            }
            else
            {
                if (Log.account != null)
                {
                    Dictionary<string, int> ingredienti = new Dictionary<string, int>();
                    Dispensa dispensa = Dispensa.GetIsance();
                    bool f = true;
                    do
                    {
                        string Prodotto = front.Stampa("StampaPerManutentore");
                        switch (Prodotto)
                        {
                            case "fine":
                                f = false;
                                break;
                            case "acqua":
                            case "polvere caffè":
                            case "latte":
                            case "zucchero":
                            case "polvere the":
                            case "cacao":
                                ingredienti.Add(Prodotto, int.Parse(front.Stampa("StampaPerManutentore")));
                                break;
                            default:
                                front.Stampa("InserimentoNonValido");
                                break;
                        }
                    } while (f);
                    dispensa.Aggiungi(ingredienti);
                    front.Stampa("AggiornamentoDispensa");
                }
                front.Stampa("ImpossibilitaOperazione");
            }
        }
        static void IManutentore()
        {
            IsManutentore = AccountManager.Lenght();
        }
    }
}
