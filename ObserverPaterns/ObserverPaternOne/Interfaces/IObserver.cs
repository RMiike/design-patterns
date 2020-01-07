using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPaternOne.Interfaces
{
    interface IObserver
    {
        public void update(float temp, float humidity, float presure);
    }
}
