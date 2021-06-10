using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Macchinacaffe.ElementiMacchina;
using Macchinacaffe.Account;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_crea()
        {
            Assert.IsNotNull(new Account("mario", "rossi"));
        }
        [TestMethod]
        public void Test_Account_uguali()
        {
            Account pippo = new Account("mario", "rossi");
            AccountManager.Crea(pippo);
            Assert.AreSame(AccountManager.Crea(pippo), AccountManager.Trova("mario", "rossi"));
        }
        [TestMethod]
        public void Test_Manca()
        {
            Dispensa dispensa = Dispensa.GetIsance();
            Dictionary<string, int> ListaControllo = new Dictionary<string, int>()
            {
                {"acqua", 2},
               {"mario",5 }
            };
            Assert.IsNotNull(dispensa.ControllaIngredienti(ListaControllo));

        }
        [TestMethod]
        public void Test_Trova_Account()
        {
            Account account_tmp = new Account("pippo", "giovanni");
            AccountManager.Crea(account_tmp);
            Assert.IsNotNull(AccountManager.Trova(account_tmp.Username, account_tmp.Password));
        }
        [TestMethod]
        public void Test_Crea_Account_Con_Null()
        {
            Assert.IsNotNull(new Account(null, null));
        }
    }
}
