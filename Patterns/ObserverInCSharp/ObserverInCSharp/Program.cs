using System;
using System.Collections.Generic;
using System.Threading;

namespace ObserverInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Subject(); // Observable
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}