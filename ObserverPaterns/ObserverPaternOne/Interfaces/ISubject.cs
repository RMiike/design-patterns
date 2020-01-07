using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPaternOne.Interfaces
{
    interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObserver();
    }
}
