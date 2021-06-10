using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front
{
    public interface IFront
    {
        /// <summary>
        /// stringa per comunicare in quale parte di codce ci si trovi e settare la stampa di consegunza 1   
        /// nel caso delle eccezzioni concatenare il messaggio con ;
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Stampa(string s);
    }
}
