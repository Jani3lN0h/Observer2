using PracticaObserver2.Service.Interface;
using System;
using static PracticaObserver2.Domain.ETypesObserver;

namespace PracticaObserver2.Service
{
    public class Notifier : IObserver
    {
        public TypesObserver typeObserver => TypesObserver.Notifier;

        public void Notify(IObservable observable)
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
