using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Schermo
{
    public interface IObserver
    {
        void Update(string msg);
        void SetNull();
    }
}
