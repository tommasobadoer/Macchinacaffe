using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Schermo
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void DetachAll();
        void Notify();
        string GetStampa();
    }
}
