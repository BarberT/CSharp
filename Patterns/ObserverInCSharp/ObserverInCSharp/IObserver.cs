using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverInCSharp
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
