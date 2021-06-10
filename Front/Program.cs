using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Front
{
    public class Front : IFront
    {
        public static void Main() { }
        public string Stampa(string s)
        {
            string messaggio = null;
            string[] manca = null;
            Stampa.Stampa stampa = new Stampa.Stampa();
            Stampa.StampaConInput stampaImput = new Stampa.StampaConInput();

            if (s.Contains("Eccezione"))
            {
                try
                {
                    var tmp = s.Split(';');
                    s = tmp[0];
                    messaggio = tmp[1];
                }
                catch (Exception e) { return "0"; }
            }
            if (s.Contains("Manca"))
            {
                try
                {
                    var tmp = s.Split(';');
                    s = tmp[0];
                    manca = tmp.Skip(1).ToArray();
                }
                catch { return "0"; }
            }
            if (s.Contains("Resto"))
            {
                try
                {
                    var tmp = s.Split(';');
                    s = tmp[0];
                    messaggio = tmp[1];
                }
                catch { return "0"; }
            }

            switch (s)
            {
                case "StampaElenco":
                    return stampa.StampaElenco();
                case "GetUsernameLog":
                    return stampa.GetUsernameLog();
                case "GetUserPassword":
                    return stampa.GetPasswordLog();
                case "Attesa":
                    stampa.Attesa();
                    return null;
                case "Eccezione":
                    stampaImput.StampaEccezione(messaggio);
                    return null;
                case "AccountMiss":
                    stampa.AccountMiss();
                    return null;
                case "LogIn":
                    stampa.LogIn();
                    return null;
                case "AccountColegato":
                    stampa.AccountCollegto();
                    return null;
                case "ErrorePassword":
                    stampa.StampaErrorrPassword();
                    return null;
                case "AccountEsistente":
                    stampa.AccountEsiste();
                    return null;
                case "LogOut":
                    stampa.LogOut();
                    return null;
                case "Elimina":
                    stampa.Elimina();
                    return null;
                case "InserisciCredito":
                    return stampa.InserisciCredito();
                case "Fatto":
                    stampa.Fatto();
                    return null;
                case "AccountCreato":
                    stampa.AccountCreato();
                    return null;
                case "ImpossibilitaOperazione":
                    stampa.ImpossibilitaAccesso();
                    return null;
                case "StampaPerManutentore":
                    stampa.StampaPerManutentore();
                    return null;
                case "InserimentoNonValido":
                    stampa.InserimentoNinValido();
                    return null;
                case "AggiornamentoDispensa":
                    stampa.AggiornamentoDispensa();
                    return null;
                case "ProceduraPreparazione":
                    stampa.StapaFasiPreparazione();
                    return null;
                case "RichiestaZucchero":
                    return stampa.RischiestaZucchero();
                case "Preleva":
                    stampa.Preleva();
                    return null;
                case "manca":
                    stampaImput.Manca(manca);
                    return null;
                case "InserisciQuantità":
                    return stampa.InserimentoQuantità();
                case "CreditoInsufficente":
                    stampa.CreditoInsufficente();
                    return null;
                case "Resto":
                    stampaImput.Resto(messaggio);
                    return null;
                case "ImpossibilitaResto":
                    stampa.ImpossibileResto();
                    return null;
                case "Dispose":
                    stampa.Dispose();
                    return null;
                default:
                    return null;
            }

        }
    }
}
