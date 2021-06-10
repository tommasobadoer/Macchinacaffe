using System.Collections.Generic;

namespace Macchinacaffe.ElementiMacchina
{
    public class Dispensa
    {
        private static Dispensa Instance = null;

        static Dictionary<string, int> Deposito = new()
        {
            { "acqua", 200 },
            { "latte", 100 },
            { "polvere caffè", 200 },
            { "zucchero", 500 },
            { "cacao", 200 },
            { "polvere the", 200 }
        };

        public static Dispensa GetIsance()
        {
            if (Instance == null)
            {
                Instance = new Dispensa();
            }
            return Instance;
        }

        /// <summary>
        /// sottrae dalla dispensa gli ingredienti per la preparazione di un prodotto
        /// </summary>
        /// <param name="Rimuovi"></param>
        public void Rimuovi(Dictionary<string,int> ingredienti)
        {
            foreach (string s in ingredienti.Keys)
            {
                ingredienti.TryGetValue(s, out int tmp);
                Deposito[s] -= tmp;
            }

        }

        /// <summary>
        /// da far usare ad un manutentore, permette di ricaricare la dispensa della macchina
        /// </summary>
        /// <param name="Aggiungi"></param>
        public void Aggiungi(Dictionary<string, int> ingredienti)
        {
            foreach (string s in ingredienti.Keys)
            {
                if (Deposito.ContainsKey(s))
                {
                    Deposito[s] += ingredienti[s];
                }
            }
        }

        /// <summary>
        /// restituisce gli ingredienti mancanti per la preparazione dela bevanda
        /// </summary>
        /// <param name="ControllaIngredienti"></param>
        /// <returns></returns>
        public List<string> ControllaIngredienti(Dictionary<string, int> ingredienti)
        {
            List<string> Manca = new();
            foreach (string s in ingredienti.Keys)
            {  
                Deposito.TryGetValue(s, out int d);
                ingredienti.TryGetValue(s, out int i);
                if (d < i)
                    Manca.Add(s);
            }
            return Manca;
        }
    }
}
