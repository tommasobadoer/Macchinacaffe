using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Schermo
{
   public class Schermo : IObserver
    {
        public void SetNull() => Console.Clear();
        public void Update(string msg) => Console.WriteLine(msg);
    }
}
