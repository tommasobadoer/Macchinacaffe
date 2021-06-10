using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Schermo
{
    public class ManagerSchermi : ISubject, IDisposable
    {
        List<IObserver> _observers = new List<IObserver>();
        static ManagerSchermi Instance;
        string DaStampare;
        public static ManagerSchermi GetIstance()
        {
            if (Instance == null)
            {
                Instance = new ManagerSchermi();
            }
            return Instance;
        }
        public void Attach(IObserver observer)
        {  
            try
            {
                this._observers.Add(observer);
            }catch (Exception e )
            {
                ManagerSchermi Mschermi = ManagerSchermi.GetIstance();
                Mschermi.SetStampa(e.Message);
                return;
            }
        }
        public void DetachAll()
        {
            _observers.Clear();
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(DaStampare);
            }
        }
        /// <summary>
        /// notifica ai display che c'è una stringa da stampare
        /// </summary>
        /// <param name="SetStampa"></param>
        public void SetStampa(string s)
        {
            DaStampare = s;
            Notify();
        }
        public string GetStampa()
        {
            return DaStampare;
        }
        /// <summary>
        /// resetta la stampa degli schermi
        /// </summary>
        ///  /// <param name="SetNull"></param>
        public void SetNull()
        {
            foreach (var observer in _observers)
            {
                observer.SetNull();
            }
        }
        public void Dispose()
        {
            try
            {
                if (_observers != null)
                {
                        DetachAll();
                }
            }catch(Exception e) 
            {
                ManagerSchermi Mschermi = ManagerSchermi.GetIstance();
                Mschermi.SetStampa(e.Message);
                return;
            }
        }
    }
}
